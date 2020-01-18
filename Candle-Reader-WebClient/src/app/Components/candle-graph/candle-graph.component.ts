import { Component, OnInit, ElementRef, AfterViewInit, Input } from '@angular/core';
import * as $ from 'jquery';
import * as d3 from 'd3';
import * as techan from 'techan';
import { Candle } from 'src/app/Models/Candle';
import { ZoomBehavior, ScaleLinear } from 'd3';

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

  private candlestick: any;
  private svg: any;
  private zoomableInit: any;

  private x: any;
  private y: ScaleLinear<number, number>;
  private xAxis: d3.Axis<d3.AxisDomain>;
  private yAxis: d3.Axis<number | { valueOf(): number; }>;
  private zoom: ZoomBehavior<Element, unknown>;

  constructor(private elmentRef: ElementRef) { }

  ngOnInit() {
  }

  ngAfterViewInit(): void {
    const margin = { top: 20, right: 20, bottom: 30, left: 50 },
      width = 960 - margin.left - margin.right,
      height = 500 - margin.top - margin.bottom;

    const x = techan.scale.financetime()
      .range([0, width]);

    const y = d3.scaleLinear()
      .range([height, 0]);

    const candlestick = techan.plot.candlestick()
      .xScale(x)
      .yScale(y);

    const xAxis = d3.axisBottom(x);

    const yAxis = d3.axisLeft(y);

    const zoom = d3.zoom().on('zoom', () => this.onZoom());

    let svg = d3.select($(this.elmentRef.nativeElement).find('svg')[0]);

    svg = svg.attr('width', width + margin.left + margin.right)
      .attr('height', height + margin.top + margin.bottom)
      .append('g')
      .attr('transform', 'translate(' + margin.left + ',' + margin.top + ')');

    svg.append('g')
      .attr('class', 'candlestick');

    svg.append('g')
      .attr('class', 'x axis')
      .attr('transform', 'translate(0,' + height + ')');

    svg.append('g')
      .attr('class', 'y axis')
      .append('text')
      .attr('transform', 'rotate(-90)')
      .attr('y', 6)
      .attr('dy', '.71em')
      .style('text-anchor', 'end')
      .text('Price ($)');


    this.svg = svg;
    this.candlestick = candlestick;
    this.x = x;
    this.y = y;
    this.xAxis = xAxis;
    this.yAxis = yAxis;
    this.zoom = zoom;

    this.refreshData();
  }

  private onZoom() {
    const rescaledY = d3.event.transform.rescaleY(this.y);
    this.yAxis.scale(rescaledY);

    this.candlestick.yScale(rescaledY);

    // Emulates D3 behaviour, required for financetime due to secondary zoomable scale
    this.x.zoomable().domain(d3.event.transform.rescaleX(this.zoomableInit).domain());

    this.draw();
  }

  private refreshData() {
    if (this.svg) {
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
    if (this.svg) {
      this.svg.selectAll('g.candlestick').datum(this.dataAccessor).call(this.candlestick);
      this.svg.selectAll('g.x.axis').call(this.xAxis);
      this.svg.selectAll('g.y.axis').call(this.yAxis);
    }
  }

}
