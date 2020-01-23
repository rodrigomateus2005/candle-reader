import { Injectable } from '@angular/core';
import { CandleSignalRService } from './candle-signal-r.service';

import { environment } from 'src/environments/environment';
import { Candle } from 'src/app/Models/Candle';
import { Quote } from 'src/app/Models/Quote';
import { Ativo } from 'src/app/Models/Ativo';

declare const $: any;

@Injectable()
export class CandleSignalRClassicService extends CandleSignalRService {

  private hubConnection: any;
  private hubProxy: any;

  private create() {
    if (!this.hubConnection) {
      $.connection.hub.url = environment.urlWebApi;

      this.hubConnection = $.hubConnection(environment.urlWebApi + '/signalr', { useDefaultPath: false });

      this.hubProxy = this.hubConnection.createHubProxy('botHub');

      this.hubProxy.on('onPriceChanged', (e) => {
        this.onPriceChange(<Quote>{
          precoCompra: e.PrecoCompra,
          precoVenda: e.PrecoVenda,
          ativo: e.Ativo,
          fechamento: e.Fechamento,
          time: new Date(e.Time)
        });
      });
    }
  }

  public conect(): Promise<void> {
    this.create();

    return new Promise((resolve, reject) => {
      this.hubConnection.start().done(() => {
        resolve();
      }).fail(reject);
    });
  }

  public getAtivos(): Promise<Ativo[]> {
    return new Promise((resolve, reject) => {
      this.hubProxy.invoke('getAtivos').done(data => {
        resolve(data.map(x => {
          return <Ativo>{
            nome: x.Nome,
            digitos: x.Digitos,
          };
        }));
      }).fail(reject);
    });
  }

  public getCandles(ativo: string, timeFrame: number): Promise<Candle[]> {
    return new Promise((resolve, reject) => {
      this.hubProxy.invoke('getCandles', ativo, timeFrame).done(data => {
        resolve(data.map(x => <Candle>{
          time: new Date(x.Time),
          close: x.Close,
          open: x.Open,
          volume: x.Volume,
          high: x.High,
          low: x.Low,
        }));
      }).fail(reject);
    });
  }

  private onPriceChange(price: Quote) {
    this.priceChanged.emit(price);
  }
}
