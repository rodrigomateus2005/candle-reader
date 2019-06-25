using System.Threading.Tasks;
using Server.Dependecy;
using Microsoft.AspNetCore.SignalR;

namespace Server.Hubs
{
    public class BotHub : Hub
    {
        private static IHubCallerClients ClientsStatic;

        private ICandleReader candleReader;
        public BotHub(ICandleReader candleReader)
        {
            this.candleReader = candleReader;
        }

        public override Task OnConnectedAsync()
        {
            this.candleReader.Clients = this.Clients;
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(System.Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }

        public Candle[] GetCandles()
        {
            return this.candleReader.GetCandles200();
        }


    }
}