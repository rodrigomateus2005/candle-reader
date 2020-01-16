import { Component, OnInit, Input, ElementRef, ViewChild } from '@angular/core';

import { createChart, IChartApi, ISeriesApi, BarData, HistogramData } from 'lightweight-charts';
import { Candle } from 'src/app/Models/Candle';

@Component({
  selector: 'app-candle-graph-trading-view',
  templateUrl: './candle-graph-trading-view.component.html',
  styleUrls: ['./candle-graph-trading-view.component.scss']
})
export class CandleGraphTradingViewComponent implements OnInit {

  private _Data: Candle[];
  public get Data(): Candle[] {
    return this._Data;
  }
  @Input()
  public set Data(value: Candle[]) {
    this._Data = value;
    this.draw();
  }

  @ViewChild('graphDiv')
  public graphDiv: ElementRef;

  private chart: IChartApi;
  private candles: ISeriesApi<'Candlestick'>;
  private volumes: ISeriesApi<'Histogram'>;

  constructor() {
  }

  ngOnInit() {
    this.chart = createChart(this.graphDiv.nativeElement, {
      width: window.innerWidth,
      height: window.innerHeight * 0.8,
      timeScale: {
        timeVisible: true,
        secondsVisible: false
      }
    });
    this.draw();
  }

  private draw() {
    if (this.chart) {

      this.chart.resize(window.innerHeight * 0.8, window.innerWidth, false);

      if (!this.candles) {
        this.candles = this.chart.addCandlestickSeries();
      }

      if (!this.volumes) {
        this.volumes = this.chart.addHistogramSeries({
          priceFormat: {
            type: 'volume',
          },
          overlay: true,
          scaleMargins: {
            top: 0.9,
            bottom: 0,
          }
        });
      }

      this.candles.setData(this.Data.map((x) => {
        return <BarData> {
          time: x.time.getTime() / 1000,
          open: x.open,
          close: x.close,
          high: x.high,
          low: x.low
        };
      }));

      this.volumes.setData(this.Data.map((x) => {
        return <HistogramData> {
          time: x.time.getTime() / 1000,
          value: x.volume
        };
      }));
    }
  }

}
