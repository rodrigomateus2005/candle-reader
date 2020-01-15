import { Component, OnInit } from '@angular/core';
import { CandleSignalRService } from 'src/app/Services/CandleSignalR/candle-signal-r.service';

@Component({
  selector: 'app-bot-view',
  templateUrl: './bot-view.component.html',
  styleUrls: ['./bot-view.component.scss']
})
export class BotViewComponent implements OnInit {

  public Data = [];

  constructor(private candleSignalRService: CandleSignalRService) {

    candleSignalRService.conect().then(() => {
      candleSignalRService.getCandles().then(data => {
        this.Data = data;
      });
    });

    // this.hubConnection.on('OnPriceChange', (retorno) => {
    //   console.log(retorno);
    // });
  }

  ngOnInit() {

  }

}
