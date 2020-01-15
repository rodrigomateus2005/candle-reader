import { Injectable } from '@angular/core';
import { CandleSignalRService } from './candle-signal-r.service';

import { environment } from 'src/environments/environment';

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

  public getCandles(): Promise<any[]> {
    return new Promise((resolve, reject) => {
      this.hubProxy.invoke('getCandles').done(data => {
        resolve(data);
      }).fail(reject);
    });
  }
}
