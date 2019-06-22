using System;
using Microsoft.AspNetCore.SignalR;

namespace Server.Dependecy
{
    public interface ICandleReader
    {
        event PriceChangedEventHandler PriceChanged;
        IHubCallerClients Clients { get; set; }

    }

    public delegate void PriceChangedEventHandler(object sender, PriceChangedEventArgs e);

    public class PriceChangedEventArgs : EventArgs
    {
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }
    }
}