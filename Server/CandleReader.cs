using System.Net;
using IO.Swagger.Model;
using Microsoft.AspNetCore.SignalR;

namespace candle_reader
{
    public class CandleReader
    {
        private const string BEARER = "f4190fc6dfd5053a9ead7ac5859877ed-ecd9409135fd86d82bde352da8de2b15";
        private IO.Swagger.Api.DefaultApi api;
        public IHubCallerClients Clients { get; set; }

        public CandleReader(IHubCallerClients Clients)
        {
            IO.Swagger.Client.Configuration.ApiKeyPrefix.Add("Authorization", "Bearer");
            IO.Swagger.Client.Configuration.ApiKey.Add("Authorization", CandleReader.BEARER);

            this.api = new IO.Swagger.Api.DefaultApi();

            this.Clients = Clients;
        }

        public void Start()
        {

            var con = new WebClient();
            con.Headers.Add("Authorization", "Bearer " + CandleReader.BEARER);

            con.OpenReadCompleted += (object sender, OpenReadCompletedEventArgs e) =>
            {
                using (var streamReader = new System.IO.StreamReader(e.Result))
                {
                    while (true)
                    {
                        var conteudoPrice = streamReader.ReadLine();
                        var conteudoHeartbeat = streamReader.ReadLine();

                        ClientPrice price = Newtonsoft.Json.JsonConvert.DeserializeObject<ClientPrice>(conteudoPrice);
                        PricingHeartbeat heartbeat = Newtonsoft.Json.JsonConvert.DeserializeObject<PricingHeartbeat>(conteudoHeartbeat);

                        InlineResponse20028 responsePrice = new InlineResponse20028();

                        responsePrice.Price = price;
                        responsePrice.Heartbeat = heartbeat;

                        this.Clients.Caller.SendCoreAsync("OnPriceChange", new object[] { responsePrice });
                    }
                }
            };

            con.OpenReadAsync(new System.Uri("https://stream-fxpractice.oanda.com/v3/accounts/" + "101-011-11435111-001" + "/pricing/stream?instruments=EUR_USD"));
        }

    }
}