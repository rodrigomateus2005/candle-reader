import { Injectable } from '@angular/core';
import { Candle } from 'src/app/Models/Candle';
import { Reversao, TipoReversao } from 'src/app/Models/Reversao';

export enum BaseAngulo {
  low,
  close,
  mediaFechamentos,
  mediaMaximas,
  open,
  high
}

@Injectable({
  providedIn: 'root'
})
export class CandleFunctionsService {

  constructor() { }

  getReversoes(data: Candle[]): Reversao[] {
    const retorno: Reversao[] = [];

    let candleAnterior: Candle = null;
    for (const candle of data) {
      if (candleAnterior) {
        const angulo = this.getAnguloEntreCandles(candleAnterior, candle, 1, BaseAngulo.mediaFechamentos);

        if (retorno.length === 0) {
          retorno.push({
            candleInicio: candle,
            tipo: angulo > 0 ? TipoReversao.fundo : TipoReversao.topo
          });
        } else {
          const ultimaReversao = retorno[retorno.length - 1];
          const tipo = angulo > 0 ? TipoReversao.fundo : TipoReversao.topo;

          let sortMaior: (a: Candle, b: Candle) => number;
          if (tipo === TipoReversao.fundo) {
            sortMaior = (a, b) => {
              if (a.low < b.low) {
                return -1;
              } else {
                return 1;
              }
            };
          } else {
            sortMaior = (a, b) => {
              if (a.high > b.high) {
                return -1;
              } else {
                return 1;
              }
            };
          }

          if (angulo && tipo !== ultimaReversao.tipo) {
            retorno.push(
              {
                candleInicio: [candleAnterior, candle].sort(sortMaior)[0],
                tipo: tipo
              }
            );
          }
        }
      }

      candleAnterior = candle;
    }

    return retorno;
  }

  public refinarReversoes(reversoes: Reversao[], data: Candle[]) {
    for (const reversao of reversoes) {
      const dataFiltrada = data
        .filter(x => x.time.getTime() > reversao.candleInicio.time.getTime());
      const indexFim = dataFiltrada
        .findIndex(x => reversao.tipo === TipoReversao.fundo ? x.low < reversao.candleInicio.low  : x.high > reversao.candleInicio.high);

      const dataFim = dataFiltrada.splice(indexFim, indexFim * 2 + 1);

      const candleFim = dataFim.length > 0 ? dataFim.reverse()[0] : dataFiltrada.reverse()[0];

      reversao.candleFim = candleFim;
    }
  }


  public getAnguloEntreCandles(candleA: Candle, candleB: Candle, distancia: number, base: BaseAngulo): number {
    if (!candleA || !candleB || !distancia) {
      return 0;
    }

    let catetoOposto = 0;

    switch (base) {
      case BaseAngulo.low:
        catetoOposto = candleB.low - candleA.low;
        break;
      case BaseAngulo.close:
        catetoOposto = candleB.close - candleA.close;
        break;
      case BaseAngulo.mediaMaximas:
        const medMaxA = (candleA.low + candleA.high) / 2;
        const medMaxB = (candleB.low + candleB.high) / 2;

        catetoOposto = medMaxB - medMaxA;
        break;
      case BaseAngulo.open:
        catetoOposto = candleB.open - candleA.open;
        break;
      case BaseAngulo.high:
        catetoOposto = candleB.high - candleA.high;
        break;
      default:
        const medFecA = (candleA.close + candleA.open) / 2;
        const medFecB = (candleB.close + candleB.open) / 2;

        catetoOposto = medFecB - medFecA;
        break;
    }

    const hipotenusa = Math.sqrt(Math.pow(catetoOposto, 2) + Math.pow(distancia, 2));
    const angulo = Math.asin(catetoOposto / hipotenusa);

    return angulo;
  }

  public verificarCandleInterceptando(candle: Candle, position: number) {
    return (position > candle.high && position > candle.low);
  }
}
