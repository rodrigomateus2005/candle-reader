import { Injectable, EventEmitter } from '@angular/core';
import { Candle } from 'src/app/Models/Candle';

@Injectable()
export abstract class CandleSignalRService {

  public priceChanged = new EventEmitter();
  public abstract conect(): Promise<void>;
  public abstract getCandles(): Promise<Candle[]>;
}
