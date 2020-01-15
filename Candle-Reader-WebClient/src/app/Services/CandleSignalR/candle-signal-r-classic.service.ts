import { Injectable } from '@angular/core';
import { CandleSignalRService } from './candle-signal-r.service';

import * as $ from 'jquery';
import 'signalr';
import { environment } from 'src/environments/environment';

@Injectable()
export class CandleSignalRClassicService extends CandleSignalRService {

  private hubConnection: any;

  private create() {
    if (!this.hubConnection) {
      $.connection.hub.url = environment.urlWebApi;

      this.hubConnection = $.hubConnection();
    }
  }

  public conect(): Promise<void> {

    throw new Error("Method not implemented.");
  }
  public getCandles(): Promise<any[]> {
    throw new Error("Method not implemented.");
  }
}
