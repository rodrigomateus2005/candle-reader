namespace candle_reader
{
    public class CandleReader
    {

        private IO.Swagger.Api.DefaultApi api;

        public CandleReader()
        {
            IO.Swagger.Client.Configuration.ApiKeyPrefix.Add("Authorization", "Bearer");
            IO.Swagger.Client.Configuration.ApiKey.Add("Authorization", "f4190fc6dfd5053a9ead7ac5859877ed-ecd9409135fd86d82bde352da8de2b15");

            this.api = new IO.Swagger.Api.DefaultApi();
        }

        public void Start()
        {
            while (true)
            {
                // https://stream-fxpractice.oanda.com/v3/accounts/:accountID/pricing/stream?instruments=EUR_USD
                this.api.StreamPricing()
            }
        }

    }
}