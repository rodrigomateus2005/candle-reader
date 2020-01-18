import { Component, OnInit, ElementRef, AfterViewInit, Input, ViewChild } from '@angular/core';
import * as $ from 'jquery';
import * as d3 from 'd3';
import * as techan from 'techan';
import { Candle } from 'src/app/Models/Candle';
import { ZoomBehavior, ScaleLinear } from 'd3';

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
export class CandleGraphComponent implements OnInit, AfterViewInit {

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

  private x: any;
  private y: ScaleLinear<number, number>;
  private xAxis: d3.Axis<d3.AxisDomain>;
  private yAxis: d3.Axis<number | { valueOf(): number; }>;
  private zoom: ZoomBehavior<Element, unknown>;

  private ohlcAnnotation: any;
  private timeAnnotation: any;
  private crosshair: any;
  private coordsText: any;

  constructor() {
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
  }

  ngOnInit() {
  }

  ngAfterViewInit(): void {
    this.createChart();
    this.createZoom();
    // this.createCrosshair();
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

    this.svgD3 = svgD3;
    this.candlestick = candlestick;
    this.x = x;
    this.y = y;
    this.xAxis = xAxis;
    this.yAxis = yAxis;
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
    const rescaledY = d3.event.transform.rescaleY(this.y);
    this.yAxis.scale(rescaledY);

    this.candlestick.yScale(rescaledY);

    // Emulates D3 behaviour, required for financetime due to secondary zoomable scale
    this.x.zoomable().domain(d3.event.transform.rescaleX(this.zoomableInit).domain());

    this.draw();
  }
  /**ZOOM END */

  /** crosshair init */
  private createCrosshair() {

    const ohlcAnnotation = techan.plot.axisannotation()
      .axis(this.yAxis)
      .orient('right')
      .translate([this.sizeInner.width, 0])
      .format(d3.format(',.2f'));

    const timeAnnotation = techan.plot.axisannotation()
      .axis(this.xAxis)
      .orient('bottom')
      .format(d3.timeFormat('%Y-%m-%d'))
      .width(65)
      .translate([0, this.sizeInner.height]);

    const xTopAxis = d3.axisTop(this.x);
    const yLeftAxis = d3.axisLeft(this.y);

    const timeTopAnnotation = techan.plot.axisannotation()
      .axis(xTopAxis)
      .orient('top');

    const ohlcLeftAnnotation = techan.plot.axisannotation()
      .axis(yLeftAxis)
      .orient('left')
      .format(d3.format(',.2f'));


    const crosshair = techan.plot.crosshair()
      .xScale(this.x)
      .yScale(this.y)
      .xAnnotation([timeAnnotation, timeTopAnnotation])
      .yAnnotation([ohlcLeftAnnotation, ohlcAnnotation])
      .on('enter', () => this.crosshairEnter())
      .on('out', () => this.crosshairOut())
      .on('move', (coords) => this.crosshairMove(coords));

    this.svgD3.append('g')
      .attr('class', 'x axis')
      .call(xTopAxis);

    this.svgD3.append('g')
      .attr('class', 'y axis')
      .call(yLeftAxis);

    const coordsText = this.svgD3.append('text')
      .style('text-anchor', 'end')
      .attr('class', 'coords')
      .attr('x', this.sizeInner.width - 5)
      .attr('y', 15);

    this.svgD3.append('g')
      .attr('class', 'x annotation top')
      .datum([{ value: this.x.domain()[80] }])
      .call(timeTopAnnotation);

    this.svgD3.append('g')
      .attr('class', 'x annotation bottom')
      .datum([{ value: this.x.domain()[30] }])
      .call(timeAnnotation);

    this.svgD3.append('g')
      .attr('class', 'y annotation left')
      .datum([{ value: 74 }, { value: 67.5 }, { value: 58 }, { value: 40 }]) // 74 should not be rendered
      .call(ohlcLeftAnnotation);

    this.svgD3.append('g')
      .attr('class', 'y annotation right')
      .datum([{ value: 61 }, { value: 52 }])
      .call(ohlcAnnotation);

    this.svgD3.append('g')
      .attr('class', 'crosshair')
      .datum({ x: this.x.domain()[80], y: 67.5 })
      .call(crosshair)
      .each((d) => { this.crosshairMove(d); }); // Display the current data

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

      this.x.domain(this.dataAccessor.map(accessor.d));
      this.y.domain(techan.scale.plot.ohlc(this.dataAccessor, accessor).domain());

      this.zoomableInit = this.x.zoomable().clamp(false).copy();

      this.draw();
    }
  }

  private draw() {
    if (this.svgD3) {
      this.svgD3.selectAll('g.candlestick').datum(this.dataAccessor).call(this.candlestick);
      this.svgD3.selectAll('g.x.axis').call(this.xAxis);
      this.svgD3.selectAll('g.y.axis').call(this.yAxis);
    }
  }

}
