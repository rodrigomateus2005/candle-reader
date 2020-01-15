import { Injectable, EventEmitter } from '@angular/core';

@Injectable()
export abstract class CandleSignalRService {

  public priceChanged = new EventEmitter();
  public abstract conect(): Promise<void>;
  public abstract getCandles(): Promise<any[]>;
}
