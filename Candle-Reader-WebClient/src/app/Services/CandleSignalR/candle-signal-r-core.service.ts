import { Injectable } from '@angular/core';
import { CandleSignalRService } from './candle-signal-r.service';
import * as signalR from '@aspnet/signalr';
import { environment } from 'src/environments/environment';

@Injectable()
export class CandleSignalRCoreService extends CandleSignalRService {

  private hubConnection: signalR.HubConnection;

  private create() {
    if (!this.hubConnection) {
      this.hubConnection = new signalR.HubConnectionBuilder()
        .withUrl(environment.urlWebApi + '/BotHub')
        .configureLogging(signalR.LogLevel.Information)
        .build();

      this.hubConnection.on('OnPriceChange', (retorno) => {
        this.onPriceChange(retorno);
      });
    }
  }

  public conect(): Promise<void> {
    this.create();

    return new Promise((resolve, reject) => {
      this.hubConnection.start().then(() => {
        resolve();
      }).catch(reject);
    });
  }

  public getCandles(): Promise<any[]> {
    return new Promise((resolve, reject) => {
      this.hubConnection.invoke('GetCandles').then(data => {
        resolve(data);
      }).catch(reject);
    });
  }

  private onPriceChange(price) {
    this.priceChanged.emit(price);
  }

}
