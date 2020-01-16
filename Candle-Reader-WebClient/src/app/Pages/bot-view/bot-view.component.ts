import { Component, OnInit, OnDestroy } from '@angular/core';
import { CandleSignalRService } from 'src/app/Services/CandleSignalR/candle-signal-r.service';
import { Candle } from 'src/app/Models/Candle';

@Component({
  selector: 'app-bot-view',
  templateUrl: './bot-view.component.html',
  styleUrls: ['./bot-view.component.scss']
})
export class BotViewComponent implements OnInit, OnDestroy {

  public Data: Candle[] = [];

  constructor(private candleSignalRService: CandleSignalRService) {

    candleSignalRService.conect().then(() => {
      candleSignalRService.getCandles().then(data => {
        this.Data = data;
      });
    });

    candleSignalRService.priceChanged.subscribe(this.priceChanged);
  }

  ngOnInit() {

  }

  ngOnDestroy(): void {
    this.candleSignalRService.priceChanged.unsubscribe();
  }

  public priceChanged(price) {
    if (this.Data) {
      this.Data[this.Data.length - 1].close = price;
    }
  }

}
