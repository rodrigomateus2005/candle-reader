import { Injectable } from '@angular/core';

@Injectable()
export abstract class CandleSignalRService {
  public abstract conect(): Promise<void>;
  public abstract getCandles(): Promise<any[]>;
}
