import { Component, OnInit, OnDestroy, ChangeDetectorRef } from '@angular/core';
import { CandleSignalRService } from 'src/app/Services/CandleSignalR/candle-signal-r.service';
import { CandleFunctionsService } from 'src/app/Services/CandleFunctions/candle-functions.service';
import { Candle } from 'src/app/Models/Candle';
import { Quote } from 'src/app/Models/Quote';
import { Trendline } from 'src/app/Models/Trendline';

import * as moment from 'moment';
import { Ativo } from 'src/app/Models/Ativo';
import { Reversao, TipoReversao } from 'src/app/Models/Reversao';
import { TipoOrdem } from 'src/app/Models/Ordem';

@Component({
  selector: 'app-bot-view',
  templateUrl: './bot-view.component.html',
  styleUrls: ['./bot-view.component.scss']
})
export class BotViewComponent implements OnInit, OnDestroy {

  private _AtivoSelecionado: Ativo;
  public get AtivoSelecionado(): Ativo {
    return this._AtivoSelecionado;
  }
  public set AtivoSelecionado(value: Ativo) {
    this._AtivoSelecionado = value;
    this.atualizarCandles();
  }
  private _TimeScale: any;
  public get TimeScale(): any {
    return this._TimeScale;
  }
  public set TimeScale(value: any) {
    this._TimeScale = value;
    this.atualizarCandles();
  }
  private _Volume: any;
  public get Volume(): any {
    return this._Volume;
  }
  public set Volume(value: any) {
    this._Volume = value;
  }

  public Ativos: Ativo[];
  public Data: Candle[] = [];
  public Trendlines: Trendline[] = [];
  public Reversoes: Reversao[] = [];
  public TimeScales = [];
  public Volumes = [];

  constructor(private candleSignalRService: CandleSignalRService,
    public candleFunctions: CandleFunctionsService,
    public changeDetectorRef: ChangeDetectorRef) {

    this.Volumes = [
      1,
      2,
      3
    ];

    this.TimeScales = [
      {
        Nome: 'M1',
        Valor: 1
      },
      {
        Nome: 'M15',
        Valor: 15
      }
    ];
    this.TimeScale = this.TimeScales[1];

    candleSignalRService.conect().then(() => {
      this.getAtivos();
    });

    candleSignalRService.priceChanged.subscribe((e) => this.priceChanged(e));
  }

  ngOnInit() {

  }

  ngOnDestroy(): void {
    this.candleSignalRService.priceChanged.unsubscribe();
  }

  public getAtivos() {
    this.candleSignalRService.getAtivos().then(ativos => {
      this.Ativos = ativos;
      if (ativos && ativos.length > 0) {
        this.AtivoSelecionado = ativos[0];
      }
      this.changeDetectorRef.detectChanges();
    });
  }

  public atualizarCandles() {
    if (!this.AtivoSelecionado) {
      this.Data = [];
      return;
    }

    this.candleSignalRService.getCandles(this.AtivoSelecionado.nome, this.TimeScale.Valor).then(data => {
      this.Data = data;
      const trendlines: Trendline[] = [];

      let isLow = false;
      do {
        isLow = !isLow;
        let dataTrend = data; // .slice(0, -2);
        while (dataTrend.length > 1) {
          const trendline = this.getTendencia(dataTrend, isLow);
          dataTrend = dataTrend.filter(x => x.time >= trendline.end.date);

          this.projetarTendencia(trendline, data);
          trendlines.push(trendline);
        }
      } while (isLow);

      this.Trendlines = trendlines;
      this.Reversoes = this.candleFunctions.getReversoes(data);
      this.candleFunctions.refinarReversoes(this.Reversoes, data);
      this.changeDetectorRef.detectChanges();
    });
  }

  public getTendencia(data: Candle[], isLow: boolean): Trendline {
    const angulos: {
      candleInicio: Candle,
      candleFim?: Candle,
      angulo: number,
      count: number,
      position: number
    }[] = [];

    for (let x = 0; x < data.length; x++) {
      const elementX = data[x];

      angulos.push({
        candleInicio: elementX,
        angulo: 90,
        count: 0,
        position: x
      });

      let menorAngulo = 90;

      for (let y = x + 1; y < data.length; y++) {
        const elementY = data[y];

        let catetoOposto;

        if (isLow) {
          catetoOposto = elementY.low - elementX.low;
        } else {
          catetoOposto = elementX.high - elementY.high;
        }

        const catetoAdjacente = y - x;

        const hipotenusa = Math.sqrt(Math.pow(catetoOposto, 2) + Math.pow(catetoAdjacente, 2));
        const angulo = Math.asin(catetoOposto / hipotenusa);

        if (angulo > menorAngulo) {
          continue;
        }

        menorAngulo = angulo;
        angulos[x].angulo = angulo;
        angulos[x].position = x;
        angulos[x].count = catetoAdjacente;
        angulos[x].candleFim = elementY;
      }
    }

    const maior = angulos.sort((a, b) => {
      if (a.position < b.position) {
        return -1;
      } else if (b.position < a.position) {
        return 1;
      } else {
        if (a.angulo < b.angulo) {
          return -1;
        } else if (b.angulo < a.angulo) {
          return 1;
        } else {
          if (a.position > b.position) {
            return -1;
          } else if (b.position > a.position) {
            return 1;
          } else {
            return 0;
          }
        }
      }
    })[0];

    return {
      start: {
        date: maior.candleInicio.time,
        value: isLow ? maior.candleInicio.low : maior.candleInicio.high
      },
      end: {
        date: maior.candleFim.time,
        value: isLow ? maior.candleFim.low : maior.candleFim.high
      }
    };
  }

  public projetarTendencia(tendencia: Trendline, candles: Candle[]) {
    const x = candles.findIndex(q => q.time.getTime() === tendencia.start.date.getTime());
    const y = candles.findIndex(q => q.time.getTime() === tendencia.end.date.getTime());

    let catetoAdjacente = y - x;
    const catetoOposto = tendencia.end.value - tendencia.start.value;
    const hipotenusa = Math.sqrt(Math.pow(catetoOposto, 2) + Math.pow(catetoAdjacente, 2));
    const angulo = Math.asin(catetoOposto / hipotenusa);

    catetoAdjacente = (candles.length - 1) - x;
    const alvo = Math.tan(angulo) * catetoAdjacente;

    tendencia.end.date = candles[candles.length - 1].time; // moment(dataProjetar).add(10, 'days').toDate();
    tendencia.end.value = tendencia.start.value + alvo;
  }

  public priceChanged(price: Quote) {
    if (this.Data && price && price.ativo === this.AtivoSelecionado.nome) {
      const ultimoCandle = this.Data.slice(-1)[0];

      if (!ultimoCandle) {
        return;
      }

      if (price.time.getTime() > ultimoCandle.time.getTime() + (1000 * 60 * this.TimeScale.Valor)) {
        this.atualizarCandles();
      } else {
        const preco = price.fechamento;
        if (preco < ultimoCandle.low) {
          ultimoCandle.low = preco;
        }

        if (preco > ultimoCandle.high) {
          ultimoCandle.high = preco;
        }

        ultimoCandle.close = preco;

        this.changeDetectorRef.detectChanges();
      }
    }
  }

  public compraClick() {
    this.candleSignalRService.addOrdem(this.AtivoSelecionado.nome, TipoOrdem.Compra, this.Volume);
  }

  public venderClick() {
    this.candleSignalRService.addOrdem(this.AtivoSelecionado.nome, TipoOrdem.Venda, this.Volume);
  }

}
