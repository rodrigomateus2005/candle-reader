using System.Net;
using IO.Swagger.Model;
using Microsoft.AspNetCore.SignalR;
using System.Linq;

namespace Server.Dependecy
{
    public class OAndaCandleReader : ICandleReader
    {
        public event PriceChangedEventHandler PriceChanged;

        private const string BEARER = "f4190fc6dfd5053a9ead7ac5859877ed-ecd9409135fd86d82bde352da8de2b15";
        private const string INSTRUMENTS = "EUR_USD";
        private const string ACCOUNT = "101-011-11435111-001";
        private IO.Swagger.Api.DefaultApi api;

        public IHubCallerClients Clients { get; set; }

        public OAndaCandleReader()
        {
            if (!IO.Swagger.Client.Configuration.ApiKeyPrefix.ContainsKey("Authorization"))
            {
                IO.Swagger.Client.Configuration.ApiKeyPrefix.Add("Authorization", "Bearer");
            }
            if (!IO.Swagger.Client.Configuration.ApiKey.ContainsKey("Authorization"))
            {
                IO.Swagger.Client.Configuration.ApiKey.Add("Authorization", OAndaCandleReader.BEARER);
            }

            this.api = new IO.Swagger.Api.DefaultApi();
        }

        public void Start()
        {

            var con = new WebClient();
            con.Headers.Add("Authorization", "Bearer " + OAndaCandleReader.BEARER);

            System.Action connect = () =>
            {
                con.OpenReadAsync(new System.Uri("https://stream-fxpractice.oanda.com/v3/accounts/" + OAndaCandleReader.ACCOUNT + "/pricing/stream?instruments=" + OAndaCandleReader.INSTRUMENTS));
            };

            con.OpenReadCompleted += (object sender, OpenReadCompletedEventArgs e) =>
            {
                try
                {
                    using (var streamReader = new System.IO.StreamReader(e.Result))
                    {
                        while (true)
                        {
                            var conteudo = streamReader.ReadLine();

                            ClientPrice price = null;
                            PricingHeartbeat heartbeat = null;

                            if (conteudo.Contains("\"type\":\"PRICE\""))
                            {
                                price = Newtonsoft.Json.JsonConvert.DeserializeObject<ClientPrice>(conteudo);
                            }
                            else
                            {
                                heartbeat = Newtonsoft.Json.JsonConvert.DeserializeObject<PricingHeartbeat>(conteudo);
                            }

                            var responsePrice = new InlineResponse20028();

                            responsePrice.Price = price;
                            responsePrice.Heartbeat = heartbeat;

                            if (price != null)
                            {
                                this.OnPriceChanged(new PriceChangedEventArgs()
                                {
                                    PrecoVenda = price.CloseoutAsk,
                                    PrecoCompra = price.CloseoutBid,
                                    Time = price.Time
                                });
                            }
                        }
                    }
                }
                catch (System.Exception)
                {
                    connect();
                }

            };

            connect();
        }

        public Candle[] GetCandles200()
        {
            var candles = this.api.GetInstrumentCandles(OAndaCandleReader.INSTRUMENTS, null, null, "M5", 200, null, null, null, null, null, null, null);

            var retorno = candles.Candles.Select(x => new Candle() {
                Open = x.Mid.O
                , Close = x.Mid.C
                , High = x.Mid.H
                , Low = x.Mid.L
            }).ToArray();

            return retorno;
        }

        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            this.PriceChanged?.Invoke(this, e);
            this.Clients?.Caller.SendCoreAsync("OnPriceChange", new object[] {
                    e
                 });
        }
    }
}