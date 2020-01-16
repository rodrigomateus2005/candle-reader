import { Component, OnInit, Input, ElementRef, ViewChild, IterableDiffer, IterableDiffers, DoCheck, KeyValueDiffer, KeyValueDiffers } from '@angular/core';

import { createChart, IChartApi, ISeriesApi, BarData, HistogramData } from 'lightweight-charts';
import { Candle } from 'src/app/Models/Candle';

@Component({
  selector: 'app-candle-graph-trading-view',
  templateUrl: './candle-graph-trading-view.component.html',
  styleUrls: ['./candle-graph-trading-view.component.scss']
})
export class CandleGraphTradingViewComponent implements OnInit, DoCheck {

  private _Data: Candle[];
  public get Data(): Candle[] {
    return this._Data;
  }
  @Input()
  public set Data(value: Candle[]) {
    this._Data = value;
    this.draw();
  }

  private dataDiffer: IterableDiffer<Candle>;
  private lastCandleDiffer: KeyValueDiffer<string, any>;

  @ViewChild('graphDiv')
  public graphDiv: ElementRef;

  private chart: IChartApi;
  private candles: ISeriesApi<'Candlestick'>;
  private volumes: ISeriesApi<'Histogram'>;

  constructor(private id: IterableDiffers, private kvd: KeyValueDiffers) {
    this.dataDiffer = id.find([]).create();
    this.lastCandleDiffer = kvd.find({}).create();
  }

  ngDoCheck(): void {
    const dataChanges = this.dataDiffer.diff(this.Data);
    if (dataChanges) {
      this.draw();
    }

    if (this.Data) {
      const lastCandleChanges = this.lastCandleDiffer.diff(this.Data.slice(-1)[0]);
      if (lastCandleChanges) {
        this.draw();
      }
    }
  }

  ngOnInit() {
    this.chart = createChart(this.graphDiv.nativeElement, {
      width: window.innerWidth * 0.8,
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

      this.chart.resize(window.innerHeight * 0.8, window.innerWidth * 0.8, false);

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
