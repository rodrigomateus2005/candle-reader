using Microsoft.AspNetCore.SignalR;

namespace candle_reader.Hubs
{
    public class BotHub : Hub
    {
        private CandleReader candleReader;
        public BotHub() {
            this.candleReader = new CandleReader(this.Clients);
            this.candleReader.Start();
        }

        override OnConnectedAsync() {
            
        }


    }
}