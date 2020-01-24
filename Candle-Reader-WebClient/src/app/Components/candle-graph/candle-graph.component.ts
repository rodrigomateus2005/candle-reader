import { Component, OnInit, ElementRef, AfterViewInit, Input, ViewChild, KeyValueDiffers, KeyValueDiffer, DoCheck } from '@angular/core';
import { Candle } from 'src/app/Models/Candle';
import { ZoomBehavior, ScaleLinear } from 'd3';
import { Trendline } from 'src/app/Models/Trendline';
import { Ativo } from 'src/app/Models/Ativo';
import { TipoReversao, Reversao } from 'src/app/Models/Reversao';

// import * as d3 from 'd3';
// import * as techan from 'techan';
declare const d3: any;
declare const techan: any;


export interface Margin {
  top: number;
  right: number;
  bottom: number;
  left: number;
}

export interface Size {
  width: number;
  height: number;
}

@Component({
  selector: 'app-candle-graph',
  templateUrl: './candle-graph.component.html',
  styleUrls: ['./candle-graph.component.scss']
})
export class CandleGraphComponent implements OnInit, AfterViewInit, DoCheck {

  private dataAccessor: any;

  private _Data: Candle[];
  public get Data(): Candle[] {
    return this._Data;
  }
  @Input()
  public set Data(value: Candle[]) {
    this._Data = value;
    this.refreshData();
  }

  private _trendlines: Trendline[];
  public get trendlines(): Trendline[] {
    return this._trendlines;
  }
  @Input()
  public set trendlines(value: Trendline[]) {
    this._trendlines = value;
    this.refreshData();
  }

  private _reversoes: Reversao[];
  public get reversoes(): Reversao[] {
    return this._reversoes;
  }
  @Input()
  public set reversoes(value: Reversao[]) {
    this._reversoes = value;
    this.refreshData();
  }

  private _ativo: Ativo;
  public get ativo(): Ativo {
    return this._ativo;
  }
  @Input()
  public set ativo(value: Ativo) {
    this._ativo = value;
  }

  @ViewChild('svg')
  public svg: ElementRef;

  private margin: Margin;
  private size: Size;
  private get sizeInner(): Size {
    return {
      width: this.size.width - this.margin.left - this.margin.right,
      height: this.size.height - this.margin.top - this.margin.bottom
    };
  }

  private candlestick: any;
  private svgD3: d3.Selection<SVGElement, unknown, null, undefined>;
  private zoomableInit: any;
  private yInit: any;

  private x: any;
  private y: ScaleLinear<number, number>;
  private xAxis: d3.Axis<d3.AxisDomain>;
  private yAxis: d3.Axis<number | { valueOf(): number; }>;
  private zoom: ZoomBehavior<Element, unknown>;
  private lastZoomX: any;
  private lastZoomY: any;

  private ohlcAnnotation: any;
  private timeAnnotation: any;
  private closeAnnotation: any;
  private crosshair: any;
  private coordsText: any;

  private trendlinePlot: any;

  private supstancePlot: any;

  private lastCandleDiffer: KeyValueDiffer<string, any>;

  constructor(private kvd: KeyValueDiffers) {
    this.margin = {
      top: 20,
      right: 50,
      bottom: 30,
      left: 20
    };

    this.size = {
      width: 960,
      height: 500
    };

    this.lastCandleDiffer = kvd.find({}).create();
  }

  ngDoCheck(): void {
    if (this.Data) {
      const lastCandleChanges = this.lastCandleDiffer.diff(this.Data.slice(-1)[0]);
      if (lastCandleChanges) {
        this.refreshData();
      }
    }
  }

  ngOnInit() {
  }

  ngAfterViewInit(): void {
    this.createChart();
    this.createZoom();
    this.createCrosshair();
    this.createTrendlines();
    this.createSupstances();
    this.refreshData();
  }

  private createChart() {
    const x = techan.scale.financetime()
      .range([0, this.sizeInner.width]);

    const y = d3.scaleLinear()
      .range([this.sizeInner.height, 0]);

    const candlestick = techan.plot.candlestick()
      .xScale(x)
      .yScale(y);

    const xAxis = d3.axisBottom(x);

    const yAxis = d3.axisRight(y);

    const closeAnnotation = techan.plot.axisannotation()
      .orient('right')
      .accessor(candlestick.accessor())
      .axis(yAxis)
      .format(d3.format(',.5f'))
      .translate([this.sizeInner.width, 0]);

    let svgD3 = d3.select(this.svg.nativeElement as SVGElement);

    svgD3 = svgD3.attr('width', this.size.width)
      .attr('height', this.size.height)
      .append('g')
      .attr('transform', 'translate(' + this.margin.left + ',' + this.margin.top + ')');

    svgD3.append('clipPath')
      .attr('id', 'clip')
      .append('rect')
      .attr('x', 0)
      .attr('y', y(1))
      .attr('width', this.sizeInner.width)
      .attr('height', y(0) - y(1));

    svgD3.append('g')
      .attr('class', 'candlestick')
      .attr('clip-path', 'url(#clip)');

    svgD3.append('g')
      .attr('class', 'x axis')
      .attr('transform', 'translate(0,' + this.sizeInner.height + ')');

    svgD3.append('g')
      .attr('class', 'y axis')
      .attr('transform', 'translate(' + this.sizeInner.width + ', 0)')
      .append('text')
      .attr('transform', 'rotate(90)')
      .attr('x', 60)
      .attr('y', 100)
      .attr('dx', '.71em')
      .style('text-anchor', 'end')
      .text('Preço ($)');

    svgD3.append('g')
      .attr('class', 'closeValue annotation up');

    this.svgD3 = svgD3;
    this.candlestick = candlestick;
    this.x = x;
    this.y = y;
    this.xAxis = xAxis;
    this.yAxis = yAxis;
    this.closeAnnotation = closeAnnotation;
  }

  /**ZOOM INIT */
  private createZoom() {
    if (this.svgD3) {
      if (!this.zoom) {
        const zoom = d3.zoom().on('zoom', () => this.onZoom());

        this.svgD3.append('rect')
          .attr('class', 'pane')
          .attr('width', this.sizeInner.width)
          .attr('height', this.sizeInner.height)
          .call(zoom as any);

        this.zoom = zoom;
      }
    }
  }

  private onZoom() {
    // Emulates D3 behaviour, required for financetime due to secondary zoomable scale

    this.lastZoomX = d3.event.transform.rescaleX(this.zoomableInit).domain();
    this.lastZoomY = d3.event.transform.rescaleY(this.yInit).domain();

    this.x.zoomable().domain(this.lastZoomX);
    this.y.domain(this.lastZoomY);

    this.draw();
  }
  /**ZOOM END */

  /** crosshair init */
  private createCrosshair() {

    const ohlcAnnotation = techan.plot.axisannotation()
      .axis(this.yAxis)
      .orient('right')
      .translate([this.sizeInner.width, 0])
      .format((d) => {
        let digits = 0;
        if (this.ativo) {
          digits = this.ativo.digitos;
        }
        return d3.format('.' + digits + 'f')(d);
      });

    const timeAnnotation = techan.plot.axisannotation()
      .axis(this.xAxis)
      .orient('bottom')
      .format(d3.timeFormat('%Y-%m-%d %H:%M'))
      .width(135)
      .translate([0, this.sizeInner.height]);

    const crosshair = techan.plot.crosshair()
      .xScale(this.x)
      .yScale(this.y)
      .xAnnotation([timeAnnotation])
      .yAnnotation([ohlcAnnotation])
      .on('enter', () => this.crosshairEnter())
      .on('out', () => this.crosshairOut())
      .on('move', (coords) => this.crosshairMove(coords));

    const coordsText = this.svgD3.append('text')
      .style('text-anchor', 'end')
      .attr('class', 'coords')
      .attr('x', this.sizeInner.width - 5)
      .attr('y', 15);

    this.svgD3.append('g')
      .attr('class', 'x annotation bottom')
      .datum([{ value: this.x.domain()[30] }])
      .call(timeAnnotation);

    this.svgD3.append('g')
      .attr('class', 'y annotation right')
      .datum([{ value: 61 }, { value: 52 }])
      .call(ohlcAnnotation);

    this.svgD3.append('g')
      .attr('class', 'crosshair')
      .datum({ x: this.x.domain()[80], y: 67.5 })
      .call(crosshair)
      .each((d) => { this.crosshairMove(d); })// Display the current data
      .call(this.zoom);

    this.crosshair = crosshair;
    this.coordsText = coordsText;
    this.ohlcAnnotation = ohlcAnnotation;
    this.timeAnnotation = timeAnnotation;
  }

  private crosshairEnter() {
    this.coordsText.style('display', 'inline');
  }

  private crosshairOut() {
    this.coordsText.style('display', 'none');
  }

  private crosshairMove(coords) {
    if (this.coordsText) {
      this.coordsText.text(
        this.timeAnnotation.format()(coords.x) + ', ' + this.ohlcAnnotation.format()(coords.y)
      );
    }
  }

  /** crosshair end */

  /** trendlines init */

  private createTrendlines() {
    const trendlinePlot = techan.plot.trendline()
      .xScale(this.x)
      .yScale(this.y)
      .on('mouseenter', (d) => { this.trendlineEnter(d); })
      .on('mouseout', (d) => { this.trendlineOut(d); })
      .on('drag', (d) => { this.trendlineDrag(d); });

    this.svgD3.append('g')
      .attr('class', 'trendlines')
      .attr('clip-path', 'url(#clip)');

    this.trendlinePlot = trendlinePlot;
  }

  private trendlineEnter(d: any) {
  }

  private trendlineOut(d: any) {
  }

  private trendlineDrag(d: any) {
  }

  /** trendlines end */

  /** trendlines init */

  private createSupstances() {
    const supstancePlot = techan.plot.supstance()
      .xScale(this.x)
      .yScale(this.y)
      .on('mouseenter', (d) => { this.supstanceEnter(d); })
      .on('mouseout', (d) => { this.supstanceOut(d); })
      .on('drag', (d) => { this.supstanceDrag(d); });

    this.svgD3.append('g')
      .attr('class', 'supstances')
      .attr('clip-path', 'url(#clip)');

    this.supstancePlot = supstancePlot;
  }

  private supstanceEnter(d: any) {
  }

  private supstanceOut(d: any) {
  }

  private supstanceDrag(d: any) {
  }

  /** trendlines end */

  private refreshData() {
    if (this.svgD3) {

      const accessor = this.candlestick.accessor();
      this.dataAccessor = this.Data.map(function (d) {
        return {
          date: d.time,
          open: +d.open,
          high: +d.high,
          low: +d.low,
          close: +d.close,
          volume: +d.volume
        };
      });

      this.dataAccessor.sort(function (a, b) { return d3.ascending(accessor.d(a), accessor.d(b)); });

      this.x.domain(techan.scale.plot.time(this.dataAccessor).domain());
      this.y.domain(techan.scale.plot.ohlc(this.dataAccessor, accessor).domain());

      this.zoomableInit = this.x.zoomable().clamp(false).copy();
      this.yInit = this.y.copy();

      if (this.lastZoomX && this.lastZoomY) {
        this.x.zoomable().domain(this.lastZoomX);
        this.y.domain(this.lastZoomY);
      }

      this.draw();
    }
  }

  private draw() {
    if (this.svgD3) {
      this.svgD3.selectAll('g.candlestick').datum(this.dataAccessor).call(this.candlestick);
      this.svgD3.selectAll('g.x.axis').call(this.xAxis);
      this.svgD3.selectAll('g.y.axis').call(this.yAxis);

      if (this.dataAccessor[this.dataAccessor.length - 1]) {
        this.svgD3.select('g.closeValue.annotation')
          .datum([this.dataAccessor[this.dataAccessor.length - 1]])
          .call(this.closeAnnotation);

        this.svgD3.select('g.closeValue.annotation')
          .call(this.closeAnnotation.refresh);
      }

      this.svgD3.selectAll('g.trendlines')
        .datum(this.trendlines)
        .call(this.trendlinePlot)
        // .call(this.trendlinePlot.drag)
        .call(this.trendlinePlot.refresh);

      this.svgD3.selectAll('g.supstances')
        .datum(this.reversoes.map(x => {
          return {
            start: x.candleInicio.time,
            end: x.candleFim ? x.candleFim.time : null,
            value: x.tipo === TipoReversao.fundo ? x.candleInicio.high : x.candleInicio.low
          };
        })).call(this.supstancePlot)
        // .call(this.supstancePlot.drag)
        .call(this.supstancePlot.refresh);
    }
  }

}
