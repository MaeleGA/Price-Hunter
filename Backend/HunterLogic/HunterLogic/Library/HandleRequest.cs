using System;
namespace HunterLogic.Library
{
	public class HandleRequest
	{
		public HandleRequest()
		{
            // Live Rates
            string List1 = "https://fxmarketapi.com/apilive?api_key=api_key";
            // Available Currencies
            string List2 = "https://fxmarketapi.com/apicurrencies?api_key=api_key";
            // Historical Rates
            string List3 = "https://fxmarketapi.com/apihistorical?api_key=api_key&date=2018-05-02";
            // Currency Conversion
            string List4 = "https://fxmarketapi.com/apiconvert?api_key=api_key&from=EUR&to=SEK&amount=1000";

            // Time-Series
            string List5 = "https://fxmarketapi.com/apitimeseries?api_key=api_key&currency=EURUSD,GBPUSD&start_date=2018-07-02&end_date=2018-09-03&format=ohlc";
        }
	}
}

