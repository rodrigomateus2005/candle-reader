import { Component, OnInit, OnDestroy, ChangeDetectorRef } from '@angular/core';
import { CandleSignalRService } from 'src/app/Services/CandleSignalR/candle-signal-r.service';
import { Candle } from 'src/app/Models/Candle';
import { Quote } from 'src/app/Models/Quote';

@Component({
  selector: 'app-bot-view',
  templateUrl: './bot-view.component.html',
  styleUrls: ['./bot-view.component.scss']
})
export class BotViewComponent implements OnInit, OnDestroy {

  public Data: Candle[] = [];

  constructor(private candleSignalRService: CandleSignalRService, public changeDetectorRef: ChangeDetectorRef) {

    candleSignalRService.conect().then(() => {
      this.atualizarCandles();
    });

    candleSignalRService.priceChanged.subscribe((e) => this.priceChanged(e));
  }

  ngOnInit() {

  }

  ngOnDestroy(): void {
    this.candleSignalRService.priceChanged.unsubscribe();
  }

  public atualizarCandles() {
    this.candleSignalRService.getCandles().then(data => {
      this.Data = data;
      this.changeDetectorRef.detectChanges();
    });
  }

  public priceChanged(price: Quote) {
    if (this.Data) {
      const ultimoCandle = this.Data.slice(-1)[0];

      if (price.time.getTime() > ultimoCandle.time.getTime() + (1000 * 60 * 15)) {
        this.atualizarCandles();
      } else {
        ultimoCandle.close = price.ask;
      }
    }
  }

}
