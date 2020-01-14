using System.Net;
using Microsoft.AspNetCore.SignalR;
using System.Linq;
using MtApi5;
using System;
using System.Collections.Generic;

namespace Server.Dependecy
{
    public class MetaTraderCandleReader : ICandleReader
    {
        private const string SYMBOLS_NAME = "WIN$";
        private const int PORT = 8228;

        private MtApi5Client _mtApiClient;

        public event PriceChangedEventHandler PriceChanged;

        public IHubCallerClients Clients { get; set; }

        public MetaTraderCandleReader()
        {
            this._mtApiClient = new MtApi5Client();

            this._mtApiClient.ConnectionStateChanged += this.ConnectionStateChanged;
        }

        private void ConnectionStateChanged(Object sender, Mt5ConnectionEventArgs e) {
            Console.WriteLine(e.ConnectionMessage);
        }

        public void Start()
        {
            this._mtApiClient.BeginConnect("localhost", MetaTraderCandleReader.PORT);
        }

        private Candle[] GetCandles(string symbol, ENUM_TIMEFRAMES timeFrame, int count) {
            double[] closes;
            double[] openings;
            double[] highs;
            double[] lows;
            long[] volumes;
            DateTime[] dates;

            this._mtApiClient.CopyClose(symbol, timeFrame, 0, count, out closes);
            this._mtApiClient.CopyOpen(symbol, timeFrame, 0, count, out openings);
            this._mtApiClient.CopyHigh(symbol, timeFrame, 0, count, out highs);
            this._mtApiClient.CopyLow(symbol, timeFrame, 0, count, out lows);
            this._mtApiClient.CopyTickVolume(symbol, timeFrame, 0, count, out volumes);
            this._mtApiClient.CopyTime(symbol, timeFrame, 0, count, out dates);

            List<Candle> retorno = new List<Candle>();
            for (int i = 0; i < count; i++)
            {
                retorno.Add(new Candle() {
                    Open = (decimal)openings[i],
                    Close = (decimal)closes[i],
                    High = (decimal)highs[i],
                    Low = (decimal)lows[i],
                    Volume = volumes[i],
                    Time = dates[i]
                });
            }
            return retorno.ToArray();
        }

        public Candle[] GetCandles200()
        {
            
            var retorno = this.GetCandles(MetaTraderCandleReader.SYMBOLS_NAME,
                ENUM_TIMEFRAMES.PERIOD_M15, 200);

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