namespace ccxt.pro;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class luno { public luno(object args = null) : base(args) { } }
public partial class luno : ccxt.luno
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "has", new Dictionary<string, object>() {
                { "ws", true },
                { "watchTicker", false },
                { "watchTickers", false },
                { "watchTrades", true },
                { "watchTradesForSymbols", false },
                { "watchMyTrades", false },
                { "watchOrders", null },
                { "watchOrderBook", true },
                { "watchOHLCV", false },
            } },
            { "urls", new Dictionary<string, object>() {
                { "api", new Dictionary<string, object>() {
                    { "ws", "wss://ws.luno.com/api/1" },
                } },
            } },
            { "options", new Dictionary<string, object>() {
                { "sequenceNumbers", new Dictionary<string, object>() {} },
            } },
            { "streaming", new Dictionary<string, object>() {} },
            { "exceptions", new Dictionary<string, object>() {} },
        });
    }

    public async override Task<object> watchTrades(object symbol, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name luno#watchTrades
        * @description get the list of most recent trades for a particular symbol
        * @see https://www.luno.com/en/developers/api#tag/Streaming-API
        * @param {string} symbol unified symbol of the market to fetch trades for
        * @param {int} [since] timestamp in ms of the earliest trade to fetch
        * @param {int} [limit] the maximum amount of    trades to fetch
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object[]} a list of [trade structures]{@link https://docs.ccxt.com/#/?id=public-trades}
        */
        parameters ??= new Dictionary<string, object>();
        this.checkRequiredCredentials();
        await this.loadMarkets();
        object market = this.market(symbol);
        symbol = getValue(market, "symbol");
        object subscriptionHash = add("/stream/", getValue(market, "id"));
        object subscription = new Dictionary<string, object>() {
            { "symbol", symbol },
        };
        object url = add(getValue(getValue(this.urls, "api"), "ws"), subscriptionHash);
        object messageHash = add("trades:", symbol);
        object subscribe = new Dictionary<string, object>() {
            { "api_key_id", this.apiKey },
            { "api_key_secret", this.secret },
        };
        object request = this.deepExtend(subscribe, parameters);
        object trades = await this.watch(url, messageHash, request, subscriptionHash, subscription);
        if (isTrue(this.newUpdates))
        {
            limit = callDynamically(trades, "getLimit", new object[] {symbol, limit});
        }
        return this.filterBySinceLimit(trades, since, limit, "timestamp", true);
    }

    public virtual void handleTrades(WebSocketClient client, object message, object subscription)
    {
        //
        //     {
        //         "sequence": "110980825",
        //         "trade_updates": [],
        //         "create_update": {
        //             "order_id": "BXHSYXAUMH8C2RW",
        //             "type": "ASK",
        //             "price": "24081.09000000",
        //             "volume": "0.07780000"
        //         },
        //         "delete_update": null,
        //         "status_update": null,
        //         "timestamp": 1660598775360
        //     }
        //
        object rawTrades = this.safeValue(message, "trade_updates", new List<object>() {});
        object length = getArrayLength(rawTrades);
        if (isTrue(isEqual(length, 0)))
        {
            return;
        }
        object symbol = getValue(subscription, "symbol");
        object market = this.market(symbol);
        object messageHash = add("trades:", symbol);
        object stored = this.safeValue(this.trades, symbol);
        if (isTrue(isEqual(stored, null)))
        {
            object limit = this.safeInteger(this.options, "tradesLimit", 1000);
            stored = new ArrayCache(limit);
            ((IDictionary<string,object>)this.trades)[(string)symbol] = stored;
        }
        for (object i = 0; isLessThan(i, getArrayLength(rawTrades)); postFixIncrement(ref i))
        {
            object rawTrade = getValue(rawTrades, i);
            object trade = this.parseTrade(rawTrade, market);
            callDynamically(stored, "append", new object[] {trade});
        }
        ((IDictionary<string,object>)this.trades)[(string)symbol] = stored;
        callDynamically(client as WebSocketClient, "resolve", new object[] {getValue(this.trades, symbol), messageHash});
    }

    public override object parseTrade(object trade, object market = null)
    {
        //
        // watchTrades (public)
        //
        //     {
        //       "base": "69.00000000",
        //       "counter": "113.6499000000000000",
        //       "maker_order_id": "BXEEU4S2BWF5WRB",
        //       "taker_order_id": "BXKNCSF7JDHXY3H",
        //       "order_id": "BXEEU4S2BWF5WRB"
        //     }
        //
        return this.safeTrade(new Dictionary<string, object>() {
            { "info", trade },
            { "id", null },
            { "timestamp", null },
            { "datetime", null },
            { "symbol", getValue(market, "symbol") },
            { "order", null },
            { "type", null },
            { "side", null },
            { "takerOrMaker", null },
            { "price", null },
            { "amount", this.safeString(trade, "base") },
            { "cost", this.safeString(trade, "counter") },
            { "fee", null },
        }, market);
    }

    public async override Task<object> watchOrderBook(object symbol, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name luno#watchOrderBook
        * @description watches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
        * @param {string} symbol unified symbol of the market to fetch the order book for
        * @param {int} [limit] the maximum amount of order book entries to return
        * @param {objectConstructor} [params] extra parameters specific to the exchange API endpoint
        * @param {string} [params.type] accepts l2 or l3 for level 2 or level 3 order book
        * @returns {object} A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        this.checkRequiredCredentials();
        await this.loadMarkets();
        object market = this.market(symbol);
        symbol = getValue(market, "symbol");
        object subscriptionHash = add("/stream/", getValue(market, "id"));
        object subscription = new Dictionary<string, object>() {
            { "symbol", symbol },
        };
        object url = add(getValue(getValue(this.urls, "api"), "ws"), subscriptionHash);
        object messageHash = add("orderbook:", symbol);
        object subscribe = new Dictionary<string, object>() {
            { "api_key_id", this.apiKey },
            { "api_key_secret", this.secret },
        };
        object request = this.deepExtend(subscribe, parameters);
        object orderbook = await this.watch(url, messageHash, request, subscriptionHash, subscription);
        return (orderbook as IOrderBook).limit();
    }

    public virtual void handleOrderBook(WebSocketClient client, object message, object subscription)
    {
        //
        //     {
        //         "sequence": "24352",
        //         "asks": [{
        //             "id": "BXMC2CJ7HNB88U4",
        //             "price": "1234.00",
        //             "volume": "0.93"
        //         }],
        //         "bids": [{
        //             "id": "BXMC2CJ7HNB88U5",
        //             "price": "1201.00",
        //             "volume": "1.22"
        //         }],
        //         "status": "ACTIVE",
        //         "timestamp": 1528884331021
        //     }
        //
        //  update
        //     {
        //         "sequence": "110980825",
        //         "trade_updates": [],
        //         "create_update": {
        //             "order_id": "BXHSYXAUMH8C2RW",
        //             "type": "ASK",
        //             "price": "24081.09000000",
        //             "volume": "0.07780000"
        //         },
        //         "delete_update": null,
        //         "status_update": null,
        //         "timestamp": 1660598775360
        //     }
        //
        object symbol = getValue(subscription, "symbol");
        object messageHash = add("orderbook:", symbol);
        object timestamp = this.safeInteger(message, "timestamp");
        if (!isTrue((inOp(this.orderbooks, symbol))))
        {
            ((IDictionary<string,object>)this.orderbooks)[(string)symbol] = this.indexedOrderBook(new Dictionary<string, object>() {});
        }
        object orderbook = getValue(this.orderbooks, symbol);
        object asks = this.safeValue(message, "asks");
        if (isTrue(!isEqual(asks, null)))
        {
            object snapshot = this.customParseOrderBook(message, symbol, timestamp, "bids", "asks", "price", "volume", "id");
            (orderbook as IOrderBook).reset(snapshot);
        } else
        {
            this.handleDelta(orderbook, message);
            ((IDictionary<string,object>)orderbook)["timestamp"] = timestamp;
            ((IDictionary<string,object>)orderbook)["datetime"] = this.iso8601(timestamp);
        }
        object nonce = this.safeInteger(message, "sequence");
        ((IDictionary<string,object>)orderbook)["nonce"] = nonce;
        callDynamically(client as WebSocketClient, "resolve", new object[] {orderbook, messageHash});
    }

    public virtual object customParseOrderBook(object orderbook, object symbol, object timestamp = null, object bidsKey = null, object asksKey = null, object priceKey = null, object amountKey = null, object countOrIdKey = null)
    {
        bidsKey ??= "bids";
        asksKey ??= "asks";
        priceKey ??= "price";
        amountKey ??= "volume";
        countOrIdKey ??= 2;
        object bids = this.parseBidsAsks(this.safeValue(orderbook, bidsKey, new List<object>() {}), priceKey, amountKey, countOrIdKey);
        object asks = this.parseBidsAsks(this.safeValue(orderbook, asksKey, new List<object>() {}), priceKey, amountKey, countOrIdKey);
        return new Dictionary<string, object>() {
            { "symbol", symbol },
            { "bids", this.sortBy(bids, 0, true) },
            { "asks", this.sortBy(asks, 0) },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "nonce", null },
        };
    }

    public override object parseBidsAsks(object bidasks, object priceKey = null, object amountKey = null, object thirdKey = null)
    {
        priceKey ??= "price";
        amountKey ??= "volume";
        thirdKey ??= 2;
        bidasks = this.toArray(bidasks);
        object result = new List<object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(bidasks)); postFixIncrement(ref i))
        {
            ((IList<object>)result).Add(this.customParseBidAsk(getValue(bidasks, i), priceKey, amountKey, thirdKey));
        }
        return result;
    }

    public virtual object customParseBidAsk(object bidask, object priceKey = null, object amountKey = null, object thirdKey = null)
    {
        priceKey ??= "price";
        amountKey ??= "volume";
        thirdKey ??= 2;
        object price = this.safeNumber(bidask, priceKey);
        object amount = this.safeNumber(bidask, amountKey);
        object result = new List<object>() {price, amount};
        if (isTrue(!isEqual(thirdKey, null)))
        {
            object thirdValue = ((object)this.safeString(bidask, thirdKey));
            ((IList<object>)result).Add(thirdValue);
        }
        return result;
    }

    public override void handleDelta(object orderbook, object message)
    {
        //
        //  create
        //     {
        //         "sequence": "110980825",
        //         "trade_updates": [],
        //         "create_update": {
        //             "order_id": "BXHSYXAUMH8C2RW",
        //             "type": "ASK",
        //             "price": "24081.09000000",
        //             "volume": "0.07780000"
        //         },
        //         "delete_update": null,
        //         "status_update": null,
        //         "timestamp": 1660598775360
        //     }
        //  delete
        //     {
        //         "sequence": "110980825",
        //         "trade_updates": [],
        //         "create_update": null,
        //         "delete_update": {
        //             "order_id": "BXMC2CJ7HNB88U4"
        //         },
        //         "status_update": null,
        //         "timestamp": 1660598775360
        //     }
        //  trade
        //     {
        //         "sequence": "110980825",
        //         "trade_updates": [
        //             {
        //                 "base": "0.1",
        //                 "counter": "5232.00",
        //                 "maker_order_id": "BXMC2CJ7HNB88U4",
        //                 "taker_order_id": "BXMC2CJ7HNB88U5"
        //             }
        //         ],
        //         "create_update": null,
        //         "delete_update": null,
        //         "status_update": null,
        //         "timestamp": 1660598775360
        //     }
        //
        object createUpdate = this.safeValue(message, "create_update");
        object asksOrderSide = getValue(orderbook, "asks");
        object bidsOrderSide = getValue(orderbook, "bids");
        if (isTrue(!isEqual(createUpdate, null)))
        {
            object bidAskArray = this.customParseBidAsk(createUpdate, "price", "volume", "order_id");
            object type = this.safeString(createUpdate, "type");
            if (isTrue(isEqual(type, "ASK")))
            {
                (asksOrderSide as IOrderBookSide).storeArray(bidAskArray);
            } else if (isTrue(isEqual(type, "BID")))
            {
                (bidsOrderSide as IOrderBookSide).storeArray(bidAskArray);
            }
        }
        object deleteUpdate = this.safeValue(message, "delete_update");
        if (isTrue(!isEqual(deleteUpdate, null)))
        {
            object orderId = this.safeString(deleteUpdate, "order_id");
            (asksOrderSide as IOrderBookSide).storeArray(new List<object>() {0, 0, orderId});
            (bidsOrderSide as IOrderBookSide).storeArray(new List<object>() {0, 0, orderId});
        }
    }

    public override void handleMessage(WebSocketClient client, object message)
    {
        if (isTrue(isEqual(message, "")))
        {
            return;
        }
        object subscriptions = new List<object>(((IDictionary<string,object>)((WebSocketClient)client).subscriptions).Values);
        object handlers = new List<object>() {this.handleOrderBook, this.handleTrades};
        for (object j = 0; isLessThan(j, getArrayLength(handlers)); postFixIncrement(ref j))
        {
            object handler = getValue(handlers, j);
            DynamicInvoker.InvokeMethod(handler, new object[] { client, message, getValue(subscriptions, 0)});
        }
    }
}
