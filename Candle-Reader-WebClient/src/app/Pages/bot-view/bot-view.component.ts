import { Component, OnInit, OnDestroy, ChangeDetectorRef } from '@angular/core';
import { CandleSignalRService } from 'src/app/Services/CandleSignalR/candle-signal-r.service';

@Component({
  selector: 'app-bot-view',
  templateUrl: './bot-view.component.html',
  styleUrls: ['./bot-view.component.scss']
})
export class BotViewComponent implements OnInit, OnDestroy {

  public Data = [];

  constructor(private candleSignalRService: CandleSignalRService, public changeDetectorRef: ChangeDetectorRef) {

    candleSignalRService.conect().then(() => {
      candleSignalRService.getCandles().then(data => {
        this.Data = data;
        this.changeDetectorRef.detectChanges();
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
    console.log(price);
  }

}
