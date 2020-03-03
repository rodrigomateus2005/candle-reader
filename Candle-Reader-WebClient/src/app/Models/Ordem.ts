export enum TipoOrdem {
    Compra,
    Venda
}

export interface Ordem {
    tipo: TipoOrdem;
    preco: number;
    perdaMaxima: number;
    lucroMaximo: number;
    executado: boolean;
}
