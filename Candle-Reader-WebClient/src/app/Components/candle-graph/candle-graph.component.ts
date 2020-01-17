import { Component, OnInit, ElementRef, AfterViewInit, Input } from '@angular/core';
import * as $ from 'jquery';
import * as d3 from 'd3';
import * as techan from 'techan';

@Component({
  selector: 'app-candle-graph',
  templateUrl: './candle-graph.component.html',
  styleUrls: ['./candle-graph.component.scss']
})
export class CandleGraphComponent implements OnInit, AfterViewInit {


  private _Data: any[];
  public get Data(): any[] {
    return this._Data;
  }
  @Input()
  public set Data(value: any[]) {
    this._Data = value;
    this.draw();
  }

  private candlestick: any;
  private svg: any;

  private x: any;
  private y: any;
  private xAxis: d3.Axis<d3.AxisDomain>;
  private yAxis: d3.Axis<number | { valueOf(): number; }>;

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

      this.draw();
  }

  private draw() {
    if (this.svg) {
      const accessor = this.candlestick.accessor();
      const data = this.Data.map(function(d) {
        return {
            date: d.Time,
            open: +d.Open,
            high: +d.High,
            low: +d.Low,
            close: +d.Close,
            volume: +d.Volume
        };
    });

      data.sort(function(a, b) { return d3.ascending(accessor.d(a), accessor.d(b)); });

      this.x.domain(data.map(accessor.d));
      this.y.domain(techan.scale.plot.ohlc(data, accessor).domain());

      this.svg.selectAll('g.candlestick').datum(data).call(this.candlestick);
      this.svg.selectAll('g.x.axis').call(this.xAxis);
      this.svg.selectAll('g.y.axis').call(this.yAxis);
    }
  }

}
