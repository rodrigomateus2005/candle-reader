using System;
using Microsoft.AspNetCore.SignalR;

namespace Server.Dependecy
{
    public interface ICandleReader
    {
        event PriceChangedEventHandler PriceChanged;
        IHubCallerClients Clients { get; set; }

        Candle[] GetCandles200();
    }

    public delegate void PriceChangedEventHandler(object sender, PriceChangedEventArgs e);

    public class PriceChangedEventArgs : EventArgs
    {
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }
        public DateTime Time { get; set; }
    }

    public class Candle
    {
        public DateTime Time { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Volume { get; set; }
    }
}