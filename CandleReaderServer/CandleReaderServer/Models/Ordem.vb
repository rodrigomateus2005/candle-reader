Public Class Ordem
    Public Enum TipoOrdem
        Compra
        Venda
    End Enum

    Public Property Tipo As TipoOrdem
    Public Property Preco As Decimal
    Public Property PerdaMaxima As Decimal
    Public Property LucroMaximo As Decimal
    Public Property Executado As Boolean
End Class
