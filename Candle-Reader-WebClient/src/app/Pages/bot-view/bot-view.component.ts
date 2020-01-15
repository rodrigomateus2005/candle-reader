import { Component, OnInit } from '@angular/core';
import * as signalR from '@aspnet/signalr';

@Component({
  selector: 'app-bot-view',
  templateUrl: './bot-view.component.html',
  styleUrls: ['./bot-view.component.scss']
})
export class BotViewComponent implements OnInit {

  private hubConnection: signalR.HubConnection;

  public Data = [];

  constructor() {
    this.hubConnection = new signalR.HubConnectionBuilder()
    .withUrl('http://localhost:44345/signalr/botHub')
    .configureLogging(signalR.LogLevel.Information)
    .build();

    this.hubConnection.start().then(() => {
      console.log('connected');

      this.hubConnection.invoke('GetCandles').then(data => {
        this.Data = data;
      }).catch(err => {
        console.error(err.toString());
      });
    });

    this.hubConnection.on('OnPriceChange', (retorno) => {
        console.log(retorno);
    });
  }

  ngOnInit() {

  }

}
