import { Injectable, EventEmitter } from '@angular/core';
import { Candle } from 'src/app/Models/Candle';
import { Quote } from 'src/app/Models/Quote';
import { Ativo } from 'src/app/Models/Ativo';
import { Ordem, TipoOrdem } from 'src/app/Models/Ordem';

@Injectable()
export abstract class CandleSignalRService {

  public priceChanged = new EventEmitter<Quote>();
  public abstract conect(): Promise<void>;
  public abstract getCandles(ativo: string, timeFrame: number): Promise<Candle[]>;
  public abstract getAtivos(): Promise<Ativo[]>;
  public abstract getOrdens(): Promise<Ordem[]>;
  public abstract addOrdem(ativo: string, tipo: TipoOrdem, volume: number): Promise<boolean>;
}
