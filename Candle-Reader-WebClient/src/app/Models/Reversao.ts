import { Candle } from './Candle';

export enum TipoReversao {
  topo,
  fundo
}

export interface Reversao {
  candleInicio: Candle;
  candleFim?: Candle;
  tipo: TipoReversao;
}
