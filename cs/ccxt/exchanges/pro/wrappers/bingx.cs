namespace ccxt.pro;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

public class  Bingx: bingx { public Bingx(object args = null) : base(args) { } }
public partial class bingx
{
    /// <summary>
    /// watches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
    /// </summary>
    /// <remarks>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/spot/socket/market.html#Subscribe%20to%2024-hour%20Price%20Change"/>  <br/>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/swapV2/socket/market.html#Subscribe%20to%2024-hour%20price%20changes"/>  <br/>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/cswap/socket/market.html#Subscribe%20to%2024-Hour%20Price%20Change"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}.</returns>
    public async Task<Ticker> WatchTicker(string symbol, Dictionary<string, object> parameters = null)
    {
        var res = await this.watchTicker(symbol, parameters);
        return new Ticker(res);
    }
    /// <summary>
    /// watches a price ticker, a statistical calculation with the information calculated over the past 24 hours for all markets of a specific list
    /// </summary>
    /// <remarks>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/swapV2/socket/market.html#Subscribe%20to%2024-hour%20price%20changes%20of%20all%20trading%20pairs"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}.</returns>
    public async Task<Tickers> WatchTickers(List<String> symbols = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.watchTickers(symbols, parameters);
        return new Tickers(res);
    }
    /// <summary>
    /// watches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
    /// </summary>
    /// <remarks>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/swapV2/socket/market.html#Subscribe%20Market%20Depth%20Data%20of%20all%20trading%20pairs"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of order book entries to return
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols.</returns>
    public async Task<ccxt.pro.IOrderBook> WatchOrderBookForSymbols(List<string> symbols, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchOrderBookForSymbols(symbols, limit, parameters);
        return ((ccxt.pro.IOrderBook) res).Copy();
    }
    /// <summary>
    /// watches historical candlestick data containing the open, high, low, and close price, and the volume of a market
    /// </summary>
    /// <remarks>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/swapV2/socket/market.html#Subscribe%20K-Line%20Data%20of%20all%20trading%20pairs"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : timestamp in ms of the earliest candle to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of candles to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>int[][]</term> A list of candles ordered as timestamp, open, high, low, close, volume.</returns>
    public async Task<Dictionary<string, Dictionary<string, List<OHLCV>>>> WatchOHLCVForSymbols(List<List<string>> symbolsAndTimeframes, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchOHLCVForSymbols(symbolsAndTimeframes, since, limit, parameters);
        return Helper.ConvertToDictionaryOHLCVList(res);
    }
    /// <summary>
    /// watches information on multiple trades made in a market
    /// </summary>
    /// <remarks>
    /// See <see href="https://bingx-api.github.io/docs/#/spot/socket/market.html#Subscribe%20to%20tick-by-tick"/>  <br/>
    /// See <see href="https://bingx-api.github.io/docs/#/swapV2/socket/market.html#Subscribe%20the%20Latest%20Trade%20Detail"/>  <br/>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/cswap/socket/market.html#Subscription%20transaction%20by%20transaction"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch orders for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of order structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Trade>> WatchTrades(string symbol, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchTrades(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Trade(item)).ToList<Trade>();
    }
    /// <summary>
    /// watches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
    /// </summary>
    /// <remarks>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/spot/socket/market.html#Subscribe%20Market%20Depth%20Data"/>  <br/>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/swapV2/socket/market.html#Subscribe%20Market%20Depth%20Data"/>  <br/>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/cswap/socket/market.html#Subscribe%20to%20Limited%20Depth"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of order book entries to return
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols.</returns>
    public async Task<ccxt.pro.IOrderBook> WatchOrderBook(string symbol, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchOrderBook(symbol, limit, parameters);
        return ((ccxt.pro.IOrderBook) res).Copy();
    }
    /// <summary>
    /// watches historical candlestick data containing the open, high, low, and close price, and the volume of a market
    /// </summary>
    /// <remarks>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/spot/socket/market.html#K-line%20Streams"/>  <br/>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/swapV2/socket/market.html#Subscribe%20K-Line%20Data"/>  <br/>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/cswap/socket/market.html#Subscribe%20to%20Latest%20Trading%20Pair%20K-Line"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : timestamp in ms of the earliest candle to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of candles to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>int[][]</term> A list of candles ordered as timestamp, open, high, low, close, volume.</returns>
    public async Task<List<OHLCV>> WatchOHLCV(string symbol, string timeframe = "1m", Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchOHLCV(symbol, timeframe, since, limit, parameters);
        return ((IList<object>)res).Select(item => new OHLCV(item)).ToList<OHLCV>();
    }
    /// <summary>
    /// watches information on multiple orders made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/spot/socket/account.html#Subscription%20order%20update%20data"/>  <br/>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/swapV2/socket/account.html#Order%20update%20push"/>  <br/>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/cswap/socket/account.html#Order%20update%20push"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>symbol</term>
    /// <description>
    /// string : unified market symbol of the market orders are made in
    /// </description>
    /// </item>
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to watch orders for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of order structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> WatchOrders(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchOrders(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// watches information on multiple trades made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/spot/socket/account.html#Subscription%20order%20update%20data"/>  <br/>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/swapV2/socket/account.html#Order%20update%20push"/>  <br/>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/cswap/socket/account.html#Order%20update%20push"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>symbol</term>
    /// <description>
    /// string : unified market symbol of the market the trades are made in
    /// </description>
    /// </item>
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to watch trades for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of trade structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [trade structures]{@link https://docs.ccxt.com/#/?id=trade-structure}.</returns>
    public async Task<List<Trade>> WatchMyTrades(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.watchMyTrades(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Trade(item)).ToList<Trade>();
    }
    /// <summary>
    /// query for balance and get the amount of funds available for trading or funds locked in orders
    /// </summary>
    /// <remarks>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/spot/socket/account.html#Subscription%20account%20balance%20push"/>  <br/>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/swapV2/socket/account.html#Account%20balance%20and%20position%20update%20push"/>  <br/>
    /// See <see href="https://bingx-api.github.io/docs/#/en-us/cswap/socket/account.html#Account%20balance%20and%20position%20update%20push"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [balance structure]{@link https://docs.ccxt.com/#/?id=balance-structure}.</returns>
    public async Task<Balances> WatchBalance(Dictionary<string, object> parameters = null)
    {
        var res = await this.watchBalance(parameters);
        return new Balances(res);
    }
}
