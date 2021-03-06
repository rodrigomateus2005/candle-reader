import { Injectable } from '@angular/core';
import { CandleSignalRService } from './candle-signal-r.service';
import * as signalR from '@aspnet/signalr';
import { environment } from 'src/environments/environment';
import { Candle } from 'src/app/Models/Candle';
import { Quote } from 'src/app/Models/Quote';
import { Ativo } from 'src/app/Models/Ativo';
import { Ordem, TipoOrdem } from 'src/app/Models/Ordem';

@Injectable()
export class CandleSignalRMockService extends CandleSignalRService {
  private candles: Candle[];
  private quote: Quote;


  constructor() {
    super();

    this.create();

    const tempoLoop = 5000; // 5 segundos
    setInterval(() => {
      if (!this.quote) {
        const lastCandle = this.candles.slice(-1)[0];
        this.quote = {
          time: lastCandle.time,
          precoCompra: lastCandle.close,
          precoVenda: lastCandle.close,
          ativo: 'EURUSD',
          fechamento: lastCandle.close
        };

      }

      const diferenca = (Math.ceil(Math.random() * 10) - 5) / 100000;

      this.quote.precoCompra += diferenca;
      this.quote.precoVenda += diferenca;
      this.quote.fechamento += diferenca;
      this.quote.time = new Date(this.quote.time.getTime() + tempoLoop);

      this.onPriceChange(this.quote);
    }, tempoLoop);
  }

  public conect(): Promise<void> {
    const retorno = this.candles;
    return Promise.resolve();
  }

  public getCandles(ativo: string, timeFrame: number): Promise<Candle[]> {
    return Promise.resolve(this.candles);
  }

  public getAtivos(): Promise<Ativo[]> {
    return Promise.resolve([<Ativo>{
      nome: 'EURUSD',
      digitos: 5
    }]);
  }

  private onPriceChange(price: Quote) {
    this.priceChanged.emit(price);
  }

  public getOrdens(): Promise<Ordem[]> {
    return Promise.resolve([]);
  }

  public addOrdem(ativo: string, tipo: TipoOrdem, volume: number): Promise<boolean> {
    throw new Error('Method not implemented.');
  }

  private create() {
    this.candles = [
      {
        'time': '2020-01-14T13:30:00',
        'open': 1.1129,
        'close': 1.11317,
        'high': 1.11325,
        'low': 1.11264,
        'volume': 468
      },
      {
        'time': '2020-01-14T13:45:00',
        'open': 1.11317,
        'close': 1.11303,
        'high': 1.11322,
        'low': 1.11262,
        'volume': 483
      },
      {
        'time': '2020-01-14T14:00:00',
        'open': 1.11303,
        'close': 1.11225,
        'high': 1.11303,
        'low': 1.11223,
        'volume': 517
      },
      {
        'time': '2020-01-14T14:15:00',
        'open': 1.11224,
        'close': 1.11236,
        'high': 1.1124,
        'low': 1.11195,
        'volume': 432
      },
      {
        'time': '2020-01-14T14:30:00',
        'open': 1.11236,
        'close': 1.11235,
        'high': 1.11238,
        'low': 1.11204,
        'volume': 316
      },
      {
        'time': '2020-01-14T14:45:00',
        'open': 1.11235,
        'close': 1.11206,
        'high': 1.11245,
        'low': 1.11194,
        'volume': 467
      },
      {
        'time': '2020-01-14T15:00:00',
        'open': 1.11206,
        'close': 1.11148,
        'high': 1.11207,
        'low': 1.11133,
        'volume': 508
      },
      {
        'time': '2020-01-14T15:15:00',
        'open': 1.11148,
        'close': 1.11096,
        'high': 1.11148,
        'low': 1.11054,
        'volume': 799
      },
      {
        'time': '2020-01-14T15:30:00',
        'open': 1.11095,
        'close': 1.11102,
        'high': 1.11157,
        'low': 1.1105,
        'volume': 1133
      },
      {
        'time': '2020-01-14T15:45:00',
        'open': 1.11101,
        'close': 1.11102,
        'high': 1.11114,
        'low': 1.11066,
        'volume': 621
      },
      {
        'time': '2020-01-14T16:00:00',
        'open': 1.11102,
        'close': 1.11059,
        'high': 1.11131,
        'low': 1.11042,
        'volume': 828
      },
      {
        'time': '2020-01-14T16:15:00',
        'open': 1.11059,
        'close': 1.11125,
        'high': 1.11127,
        'low': 1.11047,
        'volume': 619
      },
      {
        'time': '2020-01-14T16:30:00',
        'open': 1.11125,
        'close': 1.11165,
        'high': 1.11172,
        'low': 1.11122,
        'volume': 803
      },
      {
        'time': '2020-01-14T16:45:00',
        'open': 1.11165,
        'close': 1.11217,
        'high': 1.11233,
        'low': 1.11156,
        'volume': 784
      },
      {
        'time': '2020-01-14T17:00:00',
        'open': 1.11217,
        'close': 1.11194,
        'high': 1.11222,
        'low': 1.11185,
        'volume': 576
      },
      {
        'time': '2020-01-14T17:15:00',
        'open': 1.11194,
        'close': 1.11179,
        'high': 1.11202,
        'low': 1.11159,
        'volume': 680
      },
      {
        'time': '2020-01-14T17:30:00',
        'open': 1.11179,
        'close': 1.11171,
        'high': 1.11232,
        'low': 1.11136,
        'volume': 634
      },
      {
        'time': '2020-01-14T17:45:00',
        'open': 1.1117,
        'close': 1.1122,
        'high': 1.11227,
        'low': 1.11147,
        'volume': 719
      },
      {
        'time': '2020-01-14T18:00:00',
        'open': 1.1122,
        'close': 1.11263,
        'high': 1.11284,
        'low': 1.11201,
        'volume': 828
      },
      {
        'time': '2020-01-14T18:15:00',
        'open': 1.11263,
        'close': 1.1124,
        'high': 1.11265,
        'low': 1.11228,
        'volume': 324
      },
      {
        'time': '2020-01-14T18:30:00',
        'open': 1.1124,
        'close': 1.11291,
        'high': 1.11292,
        'low': 1.11238,
        'volume': 327
      },
      {
        'time': '2020-01-14T18:45:00',
        'open': 1.11291,
        'close': 1.11295,
        'high': 1.11304,
        'low': 1.11279,
        'volume': 272
      },
      {
        'time': '2020-01-14T19:00:00',
        'open': 1.11295,
        'close': 1.11309,
        'high': 1.11317,
        'low': 1.11273,
        'volume': 294
      },
      {
        'time': '2020-01-14T19:15:00',
        'open': 1.11309,
        'close': 1.11315,
        'high': 1.11327,
        'low': 1.11299,
        'volume': 243
      },
      {
        'time': '2020-01-14T19:30:00',
        'open': 1.11315,
        'close': 1.11303,
        'high': 1.11321,
        'low': 1.11294,
        'volume': 203
      },
      {
        'time': '2020-01-14T19:45:00',
        'open': 1.11303,
        'close': 1.1131,
        'high': 1.11326,
        'low': 1.11297,
        'volume': 266
      },
      {
        'time': '2020-01-14T20:00:00',
        'open': 1.1131,
        'close': 1.11315,
        'high': 1.11326,
        'low': 1.11307,
        'volume': 249
      },
      {
        'time': '2020-01-14T20:15:00',
        'open': 1.11316,
        'close': 1.1131,
        'high': 1.11318,
        'low': 1.11299,
        'volume': 196
      },
      {
        'time': '2020-01-14T20:30:00',
        'open': 1.1131,
        'close': 1.1132,
        'high': 1.11347,
        'low': 1.11309,
        'volume': 538
      },
      {
        'time': '2020-01-14T20:45:00',
        'open': 1.1132,
        'close': 1.11314,
        'high': 1.11335,
        'low': 1.11304,
        'volume': 397
      },
      {
        'time': '2020-01-14T21:00:00',
        'open': 1.11313,
        'close': 1.11316,
        'high': 1.11329,
        'low': 1.11303,
        'volume': 366
      },
      {
        'time': '2020-01-14T21:15:00',
        'open': 1.11315,
        'close': 1.1132,
        'high': 1.11325,
        'low': 1.11307,
        'volume': 214
      },
      {
        'time': '2020-01-14T21:30:00',
        'open': 1.1132,
        'close': 1.113,
        'high': 1.1132,
        'low': 1.11298,
        'volume': 176
      },
      {
        'time': '2020-01-14T21:45:00',
        'open': 1.11303,
        'close': 1.1128,
        'high': 1.11305,
        'low': 1.11279,
        'volume': 216
      },
      {
        'time': '2020-01-14T22:00:00',
        'open': 1.1128,
        'close': 1.11281,
        'high': 1.1129,
        'low': 1.1127,
        'volume': 194
      },
      {
        'time': '2020-01-14T22:15:00',
        'open': 1.11281,
        'close': 1.11297,
        'high': 1.11297,
        'low': 1.11279,
        'volume': 144
      },
      {
        'time': '2020-01-14T22:30:00',
        'open': 1.11296,
        'close': 1.11291,
        'high': 1.11297,
        'low': 1.11288,
        'volume': 150
      },
      {
        'time': '2020-01-14T22:45:00',
        'open': 1.11291,
        'close': 1.11283,
        'high': 1.11301,
        'low': 1.11276,
        'volume': 357
      },
      {
        'time': '2020-01-14T23:00:00',
        'open': 1.11283,
        'close': 1.11274,
        'high': 1.11283,
        'low': 1.11269,
        'volume': 111
      },
      {
        'time': '2020-01-14T23:15:00',
        'open': 1.11273,
        'close': 1.11254,
        'high': 1.11273,
        'low': 1.11249,
        'volume': 132
      },
      {
        'time': '2020-01-14T23:30:00',
        'open': 1.11254,
        'close': 1.11263,
        'high': 1.11263,
        'low': 1.11247,
        'volume': 81
      },
      {
        'time': '2020-01-14T23:45:00',
        'open': 1.11263,
        'close': 1.11274,
        'high': 1.11284,
        'low': 1.11253,
        'volume': 221
      },
      {
        'time': '2020-01-15T00:00:00',
        'open': 1.11284,
        'close': 1.11268,
        'high': 1.11287,
        'low': 1.1125,
        'volume': 198
      },
      {
        'time': '2020-01-15T00:15:00',
        'open': 1.11267,
        'close': 1.11264,
        'high': 1.11269,
        'low': 1.1126,
        'volume': 194
      },
      {
        'time': '2020-01-15T00:30:00',
        'open': 1.11264,
        'close': 1.11263,
        'high': 1.1127,
        'low': 1.11257,
        'volume': 141
      },
      {
        'time': '2020-01-15T00:45:00',
        'open': 1.11262,
        'close': 1.11264,
        'high': 1.11267,
        'low': 1.11261,
        'volume': 80
      },
      {
        'time': '2020-01-15T01:00:00',
        'open': 1.11263,
        'close': 1.11275,
        'high': 1.11277,
        'low': 1.11263,
        'volume': 82
      },
      {
        'time': '2020-01-15T01:15:00',
        'open': 1.11275,
        'close': 1.11274,
        'high': 1.1128,
        'low': 1.11273,
        'volume': 102
      },
      {
        'time': '2020-01-15T01:30:00',
        'open': 1.11274,
        'close': 1.1127,
        'high': 1.11279,
        'low': 1.11261,
        'volume': 246
      },
      {
        'time': '2020-01-15T01:45:00',
        'open': 1.1127,
        'close': 1.11274,
        'high': 1.11279,
        'low': 1.11266,
        'volume': 148
      },
      {
        'time': '2020-01-15T02:00:00',
        'open': 1.11274,
        'close': 1.11295,
        'high': 1.11296,
        'low': 1.11269,
        'volume': 217
      },
      {
        'time': '2020-01-15T02:15:00',
        'open': 1.11295,
        'close': 1.11301,
        'high': 1.11303,
        'low': 1.11289,
        'volume': 156
      },
      {
        'time': '2020-01-15T02:30:00',
        'open': 1.11301,
        'close': 1.11296,
        'high': 1.11304,
        'low': 1.11285,
        'volume': 221
      },
      {
        'time': '2020-01-15T02:45:00',
        'open': 1.11296,
        'close': 1.11295,
        'high': 1.11308,
        'low': 1.11288,
        'volume': 239
      },
      {
        'time': '2020-01-15T03:00:00',
        'open': 1.11295,
        'close': 1.11308,
        'high': 1.1131,
        'low': 1.1129,
        'volume': 114
      },
      {
        'time': '2020-01-15T03:15:00',
        'open': 1.11308,
        'close': 1.11274,
        'high': 1.11308,
        'low': 1.11273,
        'volume': 175
      },
      {
        'time': '2020-01-15T03:30:00',
        'open': 1.11274,
        'close': 1.11286,
        'high': 1.11287,
        'low': 1.1127,
        'volume': 178
      },
      {
        'time': '2020-01-15T03:45:00',
        'open': 1.11286,
        'close': 1.11296,
        'high': 1.11301,
        'low': 1.11285,
        'volume': 229
      },
      {
        'time': '2020-01-15T04:00:00',
        'open': 1.11295,
        'close': 1.11307,
        'high': 1.11311,
        'low': 1.11294,
        'volume': 242
      },
      {
        'time': '2020-01-15T04:15:00',
        'open': 1.11307,
        'close': 1.11295,
        'high': 1.11307,
        'low': 1.11294,
        'volume': 176
      },
      {
        'time': '2020-01-15T04:30:00',
        'open': 1.11295,
        'close': 1.11281,
        'high': 1.11297,
        'low': 1.1127,
        'volume': 141
      },
      {
        'time': '2020-01-15T04:45:00',
        'open': 1.11281,
        'close': 1.1129,
        'high': 1.11291,
        'low': 1.1127,
        'volume': 88
      },
      {
        'time': '2020-01-15T05:00:00',
        'open': 1.11291,
        'close': 1.11286,
        'high': 1.11295,
        'low': 1.11279,
        'volume': 119
      },
      {
        'time': '2020-01-15T05:15:00',
        'open': 1.11286,
        'close': 1.11297,
        'high': 1.113,
        'low': 1.11284,
        'volume': 161
      },
      {
        'time': '2020-01-15T05:30:00',
        'open': 1.11297,
        'close': 1.11304,
        'high': 1.11307,
        'low': 1.11289,
        'volume': 99
      },
      {
        'time': '2020-01-15T05:45:00',
        'open': 1.11304,
        'close': 1.11302,
        'high': 1.1131,
        'low': 1.11296,
        'volume': 103
      },
      {
        'time': '2020-01-15T06:00:00',
        'open': 1.11302,
        'close': 1.11305,
        'high': 1.11305,
        'low': 1.11295,
        'volume': 93
      },
      {
        'time': '2020-01-15T06:15:00',
        'open': 1.11305,
        'close': 1.11317,
        'high': 1.11317,
        'low': 1.11301,
        'volume': 113
      },
      {
        'time': '2020-01-15T06:30:00',
        'open': 1.11317,
        'close': 1.11329,
        'high': 1.11336,
        'low': 1.11315,
        'volume': 130
      },
      {
        'time': '2020-01-15T06:45:00',
        'open': 1.11329,
        'close': 1.11331,
        'high': 1.11336,
        'low': 1.11323,
        'volume': 170
      },
      {
        'time': '2020-01-15T07:00:00',
        'open': 1.11331,
        'close': 1.1132,
        'high': 1.11331,
        'low': 1.11317,
        'volume': 93
      },
      {
        'time': '2020-01-15T07:15:00',
        'open': 1.1132,
        'close': 1.11326,
        'high': 1.1133,
        'low': 1.1132,
        'volume': 127
      },
      {
        'time': '2020-01-15T07:30:00',
        'open': 1.11326,
        'close': 1.11322,
        'high': 1.11332,
        'low': 1.11317,
        'volume': 105
      },
      {
        'time': '2020-01-15T07:45:00',
        'open': 1.11322,
        'close': 1.11339,
        'high': 1.11345,
        'low': 1.1132,
        'volume': 93
      },
      {
        'time': '2020-01-15T08:00:00',
        'open': 1.11339,
        'close': 1.11359,
        'high': 1.11362,
        'low': 1.11328,
        'volume': 174
      },
      {
        'time': '2020-01-15T08:15:00',
        'open': 1.11359,
        'close': 1.11347,
        'high': 1.11364,
        'low': 1.11343,
        'volume': 229
      },
      {
        'time': '2020-01-15T08:30:00',
        'open': 1.11347,
        'close': 1.11329,
        'high': 1.11348,
        'low': 1.11321,
        'volume': 137
      },
      {
        'time': '2020-01-15T08:45:00',
        'open': 1.11329,
        'close': 1.11354,
        'high': 1.11355,
        'low': 1.11329,
        'volume': 98
      },
      {
        'time': '2020-01-15T09:00:00',
        'open': 1.11354,
        'close': 1.11343,
        'high': 1.11367,
        'low': 1.11334,
        'volume': 278
      },
      {
        'time': '2020-01-15T09:15:00',
        'open': 1.11343,
        'close': 1.11348,
        'high': 1.11357,
        'low': 1.11341,
        'volume': 178
      },
      {
        'time': '2020-01-15T09:30:00',
        'open': 1.11348,
        'close': 1.11293,
        'high': 1.11355,
        'low': 1.11291,
        'volume': 354
      },
      {
        'time': '2020-01-15T09:45:00',
        'open': 1.11293,
        'close': 1.11284,
        'high': 1.11311,
        'low': 1.11269,
        'volume': 253
      },
      {
        'time': '2020-01-15T10:00:00',
        'open': 1.11284,
        'close': 1.11221,
        'high': 1.11287,
        'low': 1.11214,
        'volume': 450
      },
      {
        'time': '2020-01-15T10:15:00',
        'open': 1.1122,
        'close': 1.11231,
        'high': 1.11234,
        'low': 1.11185,
        'volume': 328
      },
      {
        'time': '2020-01-15T10:30:00',
        'open': 1.11231,
        'close': 1.1123,
        'high': 1.11255,
        'low': 1.1122,
        'volume': 419
      },
      {
        'time': '2020-01-15T10:45:00',
        'open': 1.1123,
        'close': 1.113,
        'high': 1.11306,
        'low': 1.1123,
        'volume': 388
      },
      {
        'time': '2020-01-15T11:00:00',
        'open': 1.11299,
        'close': 1.113,
        'high': 1.11313,
        'low': 1.11254,
        'volume': 398
      },
      {
        'time': '2020-01-15T11:15:00',
        'open': 1.113,
        'close': 1.11319,
        'high': 1.11321,
        'low': 1.11282,
        'volume': 319
      },
      {
        'time': '2020-01-15T11:30:00',
        'open': 1.11319,
        'close': 1.11322,
        'high': 1.11333,
        'low': 1.11281,
        'volume': 643
      },
      {
        'time': '2020-01-15T11:45:00',
        'open': 1.11322,
        'close': 1.11283,
        'high': 1.11325,
        'low': 1.11275,
        'volume': 464
      },
      {
        'time': '2020-01-15T12:00:00',
        'open': 1.11283,
        'close': 1.11254,
        'high': 1.11283,
        'low': 1.1125,
        'volume': 296
      },
      {
        'time': '2020-01-15T12:15:00',
        'open': 1.11254,
        'close': 1.11305,
        'high': 1.11305,
        'low': 1.11253,
        'volume': 262
      },
      {
        'time': '2020-01-15T12:30:00',
        'open': 1.11305,
        'close': 1.11314,
        'high': 1.11327,
        'low': 1.11293,
        'volume': 205
      },
      {
        'time': '2020-01-15T12:45:00',
        'open': 1.11314,
        'close': 1.11387,
        'high': 1.11392,
        'low': 1.11314,
        'volume': 362
      },
      {
        'time': '2020-01-15T13:00:00',
        'open': 1.11387,
        'close': 1.11501,
        'high': 1.11549,
        'low': 1.11378,
        'volume': 912
      },
      {
        'time': '2020-01-15T13:15:00',
        'open': 1.11501,
        'close': 1.115,
        'high': 1.11534,
        'low': 1.11467,
        'volume': 541
      },
      {
        'time': '2020-01-15T13:30:00',
        'open': 1.115,
        'close': 1.11491,
        'high': 1.11513,
        'low': 1.11455,
        'volume': 386
      },
      {
        'time': '2020-01-15T13:45:00',
        'open': 1.11491,
        'close': 1.11479,
        'high': 1.11512,
        'low': 1.11459,
        'volume': 456
      },
      {
        'time': '2020-01-15T14:00:00',
        'open': 1.11479,
        'close': 1.11489,
        'high': 1.11516,
        'low': 1.1147,
        'volume': 376
      },
      {
        'time': '2020-01-15T14:15:00',
        'open': 1.11489,
        'close': 1.11475,
        'high': 1.11526,
        'low': 1.11473,
        'volume': 398
      },
      {
        'time': '2020-01-15T14:30:00',
        'open': 1.11475,
        'close': 1.11451,
        'high': 1.11481,
        'low': 1.11449,
        'volume': 239
      },
      {
        'time': '2020-01-15T14:45:00',
        'open': 1.11451,
        'close': 1.11407,
        'high': 1.11461,
        'low': 1.11395,
        'volume': 563
      },
      {
        'time': '2020-01-15T15:00:00',
        'open': 1.11413,
        'close': 1.11422,
        'high': 1.11448,
        'low': 1.11405,
        'volume': 466
      },
      {
        'time': '2020-01-15T15:15:00',
        'open': 1.11423,
        'close': 1.11443,
        'high': 1.11459,
        'low': 1.114,
        'volume': 572
      },
      {
        'time': '2020-01-15T15:30:00',
        'open': 1.11443,
        'close': 1.11484,
        'high': 1.11491,
        'low': 1.11429,
        'volume': 711
      },
      {
        'time': '2020-01-15T15:45:00',
        'open': 1.11484,
        'close': 1.11489,
        'high': 1.11494,
        'low': 1.11465,
        'volume': 562
      },
      {
        'time': '2020-01-15T16:00:00',
        'open': 1.11487,
        'close': 1.11521,
        'high': 1.1154,
        'low': 1.11486,
        'volume': 635
      },
      {
        'time': '2020-01-15T16:15:00',
        'open': 1.11521,
        'close': 1.11604,
        'high': 1.11606,
        'low': 1.11512,
        'volume': 612
      },
      {
        'time': '2020-01-15T16:30:00',
        'open': 1.11601,
        'close': 1.11556,
        'high': 1.11633,
        'low': 1.11545,
        'volume': 863
      },
      {
        'time': '2020-01-15T16:45:00',
        'open': 1.11556,
        'close': 1.11522,
        'high': 1.11559,
        'low': 1.11513,
        'volume': 609
      },
      {
        'time': '2020-01-15T17:00:00',
        'open': 1.11522,
        'close': 1.11442,
        'high': 1.11527,
        'low': 1.11431,
        'volume': 718
      },
      {
        'time': '2020-01-15T17:15:00',
        'open': 1.11444,
        'close': 1.11536,
        'high': 1.11547,
        'low': 1.11442,
        'volume': 498
      },
      {
        'time': '2020-01-15T17:30:00',
        'open': 1.11536,
        'close': 1.11508,
        'high': 1.11537,
        'low': 1.11496,
        'volume': 393
      },
      {
        'time': '2020-01-15T17:45:00',
        'open': 1.11508,
        'close': 1.11521,
        'high': 1.11528,
        'low': 1.11449,
        'volume': 784
      },
      {
        'time': '2020-01-15T18:00:00',
        'open': 1.11522,
        'close': 1.11574,
        'high': 1.11574,
        'low': 1.11496,
        'volume': 673
      },
      {
        'time': '2020-01-15T18:15:00',
        'open': 1.11577,
        'close': 1.11554,
        'high': 1.11594,
        'low': 1.11554,
        'volume': 416
      },
      {
        'time': '2020-01-15T18:30:00',
        'open': 1.11554,
        'close': 1.11574,
        'high': 1.11581,
        'low': 1.11544,
        'volume': 333
      },
      {
        'time': '2020-01-15T18:45:00',
        'open': 1.11574,
        'close': 1.11595,
        'high': 1.11598,
        'low': 1.11563,
        'volume': 368
      },
      {
        'time': '2020-01-15T19:00:00',
        'open': 1.11595,
        'close': 1.11564,
        'high': 1.11605,
        'low': 1.11563,
        'volume': 427
      },
      {
        'time': '2020-01-15T19:15:00',
        'open': 1.11564,
        'close': 1.11605,
        'high': 1.1161,
        'low': 1.11562,
        'volume': 405
      },
      {
        'time': '2020-01-15T19:30:00',
        'open': 1.11605,
        'close': 1.11574,
        'high': 1.11614,
        'low': 1.11568,
        'volume': 285
      },
      {
        'time': '2020-01-15T19:45:00',
        'open': 1.11575,
        'close': 1.11575,
        'high': 1.11593,
        'low': 1.11565,
        'volume': 272
      },
      {
        'time': '2020-01-15T20:00:00',
        'open': 1.11575,
        'close': 1.11588,
        'high': 1.11589,
        'low': 1.11562,
        'volume': 252
      },
      {
        'time': '2020-01-15T20:15:00',
        'open': 1.11588,
        'close': 1.11547,
        'high': 1.11596,
        'low': 1.11545,
        'volume': 244
      },
      {
        'time': '2020-01-15T20:30:00',
        'open': 1.11547,
        'close': 1.11519,
        'high': 1.11554,
        'low': 1.11504,
        'volume': 279
      },
      {
        'time': '2020-01-15T20:45:00',
        'open': 1.11519,
        'close': 1.11515,
        'high': 1.11524,
        'low': 1.11496,
        'volume': 231
      },
      {
        'time': '2020-01-15T21:00:00',
        'open': 1.11515,
        'close': 1.11506,
        'high': 1.11517,
        'low': 1.11494,
        'volume': 328
      },
      {
        'time': '2020-01-15T21:15:00',
        'open': 1.11506,
        'close': 1.11527,
        'high': 1.11527,
        'low': 1.11505,
        'volume': 248
      },
      {
        'time': '2020-01-15T21:30:00',
        'open': 1.11527,
        'close': 1.11512,
        'high': 1.11539,
        'low': 1.11512,
        'volume': 291
      },
      {
        'time': '2020-01-15T21:45:00',
        'open': 1.11514,
        'close': 1.11503,
        'high': 1.1152,
        'low': 1.11494,
        'volume': 196
      },
      {
        'time': '2020-01-15T22:00:00',
        'open': 1.11503,
        'close': 1.11494,
        'high': 1.1151,
        'low': 1.11492,
        'volume': 192
      },
      {
        'time': '2020-01-15T22:15:00',
        'open': 1.11494,
        'close': 1.11481,
        'high': 1.11497,
        'low': 1.1148,
        'volume': 189
      },
      {
        'time': '2020-01-15T22:30:00',
        'open': 1.11481,
        'close': 1.11496,
        'high': 1.1151,
        'low': 1.1148,
        'volume': 339
      },
      {
        'time': '2020-01-15T22:45:00',
        'open': 1.11496,
        'close': 1.11523,
        'high': 1.11529,
        'low': 1.11496,
        'volume': 283
      },
      {
        'time': '2020-01-15T23:00:00',
        'open': 1.11523,
        'close': 1.11496,
        'high': 1.11525,
        'low': 1.11491,
        'volume': 157
      },
      {
        'time': '2020-01-15T23:15:00',
        'open': 1.11496,
        'close': 1.11486,
        'high': 1.11496,
        'low': 1.11486,
        'volume': 82
      },
      {
        'time': '2020-01-15T23:30:00',
        'open': 1.11486,
        'close': 1.11488,
        'high': 1.11488,
        'low': 1.11482,
        'volume': 101
      },
      {
        'time': '2020-01-15T23:45:00',
        'open': 1.11485,
        'close': 1.11495,
        'high': 1.11506,
        'low': 1.11481,
        'volume': 209
      },
      {
        'time': '2020-01-16T00:00:00',
        'open': 1.11492,
        'close': 1.11511,
        'high': 1.11524,
        'low': 1.11481,
        'volume': 176
      },
      {
        'time': '2020-01-16T00:15:00',
        'open': 1.11502,
        'close': 1.11525,
        'high': 1.11534,
        'low': 1.11502,
        'volume': 267
      },
      {
        'time': '2020-01-16T00:30:00',
        'open': 1.11524,
        'close': 1.11504,
        'high': 1.11531,
        'low': 1.11503,
        'volume': 613
      },
      {
        'time': '2020-01-16T00:45:00',
        'open': 1.11505,
        'close': 1.11515,
        'high': 1.11516,
        'low': 1.11503,
        'volume': 113
      },
      {
        'time': '2020-01-16T01:00:00',
        'open': 1.11515,
        'close': 1.11517,
        'high': 1.1153,
        'low': 1.11513,
        'volume': 118
      },
      {
        'time': '2020-01-16T01:15:00',
        'open': 1.11517,
        'close': 1.11503,
        'high': 1.11522,
        'low': 1.115,
        'volume': 107
      },
      {
        'time': '2020-01-16T01:30:00',
        'open': 1.11503,
        'close': 1.11511,
        'high': 1.11519,
        'low': 1.11503,
        'volume': 106
      },
      {
        'time': '2020-01-16T01:45:00',
        'open': 1.11511,
        'close': 1.11523,
        'high': 1.11526,
        'low': 1.11508,
        'volume': 149
      },
      {
        'time': '2020-01-16T02:00:00',
        'open': 1.11524,
        'close': 1.11577,
        'high': 1.1158,
        'low': 1.11522,
        'volume': 339
      },
      {
        'time': '2020-01-16T02:15:00',
        'open': 1.11578,
        'close': 1.11573,
        'high': 1.1158,
        'low': 1.11558,
        'volume': 312
      },
      {
        'time': '2020-01-16T02:30:00',
        'open': 1.11573,
        'close': 1.11561,
        'high': 1.11577,
        'low': 1.11561,
        'volume': 199
      },
      {
        'time': '2020-01-16T02:45:00',
        'open': 1.11561,
        'close': 1.11548,
        'high': 1.11564,
        'low': 1.11539,
        'volume': 176
      },
      {
        'time': '2020-01-16T03:00:00',
        'open': 1.11548,
        'close': 1.11544,
        'high': 1.11554,
        'low': 1.11537,
        'volume': 181
      },
      {
        'time': '2020-01-16T03:15:00',
        'open': 1.11544,
        'close': 1.11544,
        'high': 1.1155,
        'low': 1.11535,
        'volume': 176
      },
      {
        'time': '2020-01-16T03:30:00',
        'open': 1.11544,
        'close': 1.11538,
        'high': 1.11547,
        'low': 1.11531,
        'volume': 142
      },
      {
        'time': '2020-01-16T03:45:00',
        'open': 1.11538,
        'close': 1.11535,
        'high': 1.11539,
        'low': 1.11529,
        'volume': 141
      },
      {
        'time': '2020-01-16T04:00:00',
        'open': 1.11535,
        'close': 1.11536,
        'high': 1.11537,
        'low': 1.11528,
        'volume': 205
      },
      {
        'time': '2020-01-16T04:15:00',
        'open': 1.11536,
        'close': 1.11519,
        'high': 1.11537,
        'low': 1.11517,
        'volume': 143
      },
      {
        'time': '2020-01-16T04:30:00',
        'open': 1.11519,
        'close': 1.11519,
        'high': 1.1152,
        'low': 1.11507,
        'volume': 88
      },
      {
        'time': '2020-01-16T04:45:00',
        'open': 1.11519,
        'close': 1.11517,
        'high': 1.11522,
        'low': 1.11515,
        'volume': 51
      },
      {
        'time': '2020-01-16T05:00:00',
        'open': 1.11517,
        'close': 1.11531,
        'high': 1.11535,
        'low': 1.11513,
        'volume': 65
      },
      {
        'time': '2020-01-16T05:15:00',
        'open': 1.11531,
        'close': 1.11544,
        'high': 1.11548,
        'low': 1.11531,
        'volume': 95
      },
      {
        'time': '2020-01-16T05:30:00',
        'open': 1.11544,
        'close': 1.11541,
        'high': 1.11549,
        'low': 1.11539,
        'volume': 144
      },
      {
        'time': '2020-01-16T05:45:00',
        'open': 1.11541,
        'close': 1.11527,
        'high': 1.11542,
        'low': 1.11525,
        'volume': 141
      },
      {
        'time': '2020-01-16T06:00:00',
        'open': 1.11527,
        'close': 1.11527,
        'high': 1.11532,
        'low': 1.11524,
        'volume': 82
      },
      {
        'time': '2020-01-16T06:15:00',
        'open': 1.11527,
        'close': 1.11526,
        'high': 1.11534,
        'low': 1.11525,
        'volume': 62
      },
      {
        'time': '2020-01-16T06:30:00',
        'open': 1.11526,
        'close': 1.11525,
        'high': 1.11531,
        'low': 1.1151,
        'volume': 147
      },
      {
        'time': '2020-01-16T06:45:00',
        'open': 1.11525,
        'close': 1.11509,
        'high': 1.11534,
        'low': 1.11506,
        'volume': 113
      },
      {
        'time': '2020-01-16T07:00:00',
        'open': 1.11509,
        'close': 1.11518,
        'high': 1.11524,
        'low': 1.11509,
        'volume': 94
      },
      {
        'time': '2020-01-16T07:15:00',
        'open': 1.11518,
        'close': 1.11509,
        'high': 1.1152,
        'low': 1.11509,
        'volume': 72
      },
      {
        'time': '2020-01-16T07:30:00',
        'open': 1.11509,
        'close': 1.11506,
        'high': 1.11511,
        'low': 1.115,
        'volume': 68
      },
      {
        'time': '2020-01-16T07:45:00',
        'open': 1.11506,
        'close': 1.11496,
        'high': 1.11512,
        'low': 1.11495,
        'volume': 112
      },
      {
        'time': '2020-01-16T08:00:00',
        'open': 1.11496,
        'close': 1.11494,
        'high': 1.11497,
        'low': 1.11475,
        'volume': 194
      },
      {
        'time': '2020-01-16T08:15:00',
        'open': 1.11494,
        'close': 1.1146,
        'high': 1.11494,
        'low': 1.11455,
        'volume': 205
      },
      {
        'time': '2020-01-16T08:30:00',
        'open': 1.1146,
        'close': 1.11477,
        'high': 1.11484,
        'low': 1.11446,
        'volume': 235
      },
      {
        'time': '2020-01-16T08:45:00',
        'open': 1.11477,
        'close': 1.11503,
        'high': 1.11505,
        'low': 1.11473,
        'volume': 149
      },
      {
        'time': '2020-01-16T09:00:00',
        'open': 1.11503,
        'close': 1.11491,
        'high': 1.11528,
        'low': 1.11486,
        'volume': 348
      },
      {
        'time': '2020-01-16T09:15:00',
        'open': 1.11491,
        'close': 1.11479,
        'high': 1.11506,
        'low': 1.11459,
        'volume': 323
      },
      {
        'time': '2020-01-16T09:30:00',
        'open': 1.11479,
        'close': 1.11462,
        'high': 1.11507,
        'low': 1.11455,
        'volume': 342
      },
      {
        'time': '2020-01-16T09:45:00',
        'open': 1.11462,
        'close': 1.11476,
        'high': 1.11481,
        'low': 1.1145,
        'volume': 318
      },
      {
        'time': '2020-01-16T10:00:00',
        'open': 1.11476,
        'close': 1.11521,
        'high': 1.11535,
        'low': 1.11458,
        'volume': 427
      },
      {
        'time': '2020-01-16T10:15:00',
        'open': 1.11521,
        'close': 1.11546,
        'high': 1.11566,
        'low': 1.11504,
        'volume': 334
      },
      {
        'time': '2020-01-16T10:30:00',
        'open': 1.11546,
        'close': 1.11588,
        'high': 1.11636,
        'low': 1.11545,
        'volume': 732
      },
      {
        'time': '2020-01-16T10:45:00',
        'open': 1.11588,
        'close': 1.11563,
        'high': 1.11604,
        'low': 1.11553,
        'volume': 414
      },
      {
        'time': '2020-01-16T11:00:00',
        'open': 1.11563,
        'close': 1.11569,
        'high': 1.11586,
        'low': 1.11553,
        'volume': 398
      },
      {
        'time': '2020-01-16T11:15:00',
        'open': 1.11569,
        'close': 1.11538,
        'high': 1.11593,
        'low': 1.11537,
        'volume': 431
      },
      {
        'time': '2020-01-16T11:30:00',
        'open': 1.11538,
        'close': 1.11534,
        'high': 1.11567,
        'low': 1.11503,
        'volume': 582
      },
      {
        'time': '2020-01-16T11:45:00',
        'open': 1.11534,
        'close': 1.11533,
        'high': 1.11547,
        'low': 1.11523,
        'volume': 338
      },
      {
        'time': '2020-01-16T12:00:00',
        'open': 1.11533,
        'close': 1.11568,
        'high': 1.11574,
        'low': 1.11525,
        'volume': 320
      },
      {
        'time': '2020-01-16T12:15:00',
        'open': 1.11568,
        'close': 1.1162,
        'high': 1.11632,
        'low': 1.11558,
        'volume': 366
      },
      {
        'time': '2020-01-16T12:30:00',
        'open': 1.1162,
        'close': 1.11574,
        'high': 1.11624,
        'low': 1.11573,
        'volume': 298
      },
      {
        'time': '2020-01-16T12:45:00',
        'open': 1.11574,
        'close': 1.11572,
        'high': 1.11591,
        'low': 1.1156,
        'volume': 273
      },
      {
        'time': '2020-01-16T13:00:00',
        'open': 1.11572,
        'close': 1.11574,
        'high': 1.11596,
        'low': 1.11566,
        'volume': 405
      },
      {
        'time': '2020-01-16T13:15:00',
        'open': 1.11574,
        'close': 1.11598,
        'high': 1.11605,
        'low': 1.11573,
        'volume': 240
      },
      {
        'time': '2020-01-16T13:30:00',
        'open': 1.11598,
        'close': 1.11583,
        'high': 1.11604,
        'low': 1.11557,
        'volume': 257
      },
      {
        'time': '2020-01-16T13:45:00',
        'open': 1.11583,
        'close': 1.11588,
        'high': 1.11596,
        'low': 1.11574,
        'volume': 291
      },
      {
        'time': '2020-01-16T14:00:00',
        'open': 1.11588,
        'close': 1.11614,
        'high': 1.1162,
        'low': 1.11577,
        'volume': 264
      },
      {
        'time': '2020-01-16T14:15:00',
        'open': 1.11614,
        'close': 1.11619,
        'high': 1.11622,
        'low': 1.11566,
        'volume': 335
      },
      {
        'time': '2020-01-16T14:30:00',
        'open': 1.11619,
        'close': 1.11669,
        'high': 1.11726,
        'low': 1.11604,
        'volume': 807
      },
      {
        'time': '2020-01-16T14:45:00',
        'open': 1.11669,
        'close': 1.11647,
        'high': 1.11673,
        'low': 1.11632,
        'volume': 435
      },
      {
        'time': '2020-01-16T15:00:00',
        'open': 1.11647,
        'close': 1.1169,
        'high': 1.11697,
        'low': 1.11624,
        'volume': 633
      },
      {
        'time': '2020-01-16T15:15:00',
        'open': 1.1169,
        'close': 1.11675,
        'high': 1.1169,
        'low': 1.11664,
        'volume': 120
      }
    ].map(x => {
      return <Candle>{
        time: new Date(x.time),
        open: x.open,
        close: x.close,
        high: x.high,
        low: x.low,
        volume: x.volume,
      };
    });
  }

}
