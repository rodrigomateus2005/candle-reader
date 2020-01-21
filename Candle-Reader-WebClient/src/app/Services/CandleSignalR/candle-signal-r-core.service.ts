import { Injectable } from '@angular/core';
import { CandleSignalRService } from './candle-signal-r.service';
import * as signalR from '@aspnet/signalr';
import { environment } from 'src/environments/environment';
import { Candle } from 'src/app/Models/Candle';
import { Quote } from 'src/app/Models/Quote';

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

  public getAtivos(): Promise<string[]> {
    return new Promise((resolve, reject) => {
      this.hubConnection.invoke('GetAtivos').then(data => {
        resolve(data);
      }).catch(reject);
    });
  }

  public getCandles(ativo: string): Promise<Candle[]> {
    return new Promise((resolve, reject) => {
      this.hubConnection.invoke('GetCandles', ativo).then(data => {
        resolve(data);
      }).catch(reject);
    });
  }

  private onPriceChange(price: Quote) {
    this.priceChanged.emit(price);
  }

}
