namespace ccxt.pro;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class hollaex { public hollaex(object args = null) : base(args) { } }
public partial class hollaex : ccxt.hollaex
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "has", new Dictionary<string, object>() {
                { "ws", true },
                { "watchBalance", true },
                { "watchMyTrades", false },
                { "watchOHLCV", false },
                { "watchOrderBook", true },
                { "watchOrders", true },
                { "watchTicker", false },
                { "watchTickers", false },
                { "watchTrades", true },
                { "watchTradesForSymbols", false },
            } },
            { "urls", new Dictionary<string, object>() {
                { "api", new Dictionary<string, object>() {
                    { "ws", "wss://api.hollaex.com/stream" },
                } },
                { "test", new Dictionary<string, object>() {
                    { "ws", "wss://api.sandbox.hollaex.com/stream" },
                } },
            } },
            { "options", new Dictionary<string, object>() {
                { "watchBalance", new Dictionary<string, object>() {} },
                { "watchOrders", new Dictionary<string, object>() {} },
            } },
            { "streaming", new Dictionary<string, object>() {
                { "ping", this.ping },
            } },
            { "exceptions", new Dictionary<string, object>() {
                { "ws", new Dictionary<string, object>() {
                    { "exact", new Dictionary<string, object>() {
                        { "Bearer or HMAC authentication required", typeof(BadSymbol) },
                        { "Error: wrong input", typeof(BadRequest) },
                    } },
                } },
            } },
        });
    }

    public async override Task<object> watchOrderBook(object symbol, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name hollaex#watchOrderBook
        * @description watches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
        * @param {string} symbol unified symbol of the market to fetch the order book for
        * @param {int} [limit] the maximum amount of order book entries to return
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object} A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object messageHash = add(add("orderbook", ":"), getValue(market, "id"));
        object orderbook = await this.watchPublic(messageHash, parameters);
        return (orderbook as IOrderBook).limit();
    }

    public virtual void handleOrderBook(WebSocketClient client, object message)
    {
        //
        //     {
        //         "topic":"orderbook",
        //         "action":"partial",
        //         "symbol":"ltc-usdt",
        //         "data":{
        //             "bids":[
        //                 [104.29, 5.2264],
        //                 [103.86,1.3629],
        //                 [101.82,0.5942]
        //             ],
        //             "asks":[
        //                 [104.81,9.5531],
        //                 [105.54,0.6416],
        //                 [106.18,1.4141],
        //             ],
        //             "timestamp":"2022-04-12T08:17:05.932Z"
        //         },
        //         "time":1649751425
        //     }
        //
        object marketId = this.safeString(message, "symbol");
        object channel = this.safeString(message, "topic");
        object market = this.safeMarket(marketId);
        object symbol = getValue(market, "symbol");
        object data = this.safeValue(message, "data");
        object timestamp = this.safeString(data, "timestamp");
        object timestampMs = this.parse8601(timestamp);
        object snapshot = this.parseOrderBook(data, symbol, timestampMs);
        object orderbook = null;
        if (!isTrue((inOp(this.orderbooks, symbol))))
        {
            orderbook = this.orderBook(snapshot);
            ((IDictionary<string,object>)this.orderbooks)[(string)symbol] = orderbook;
        } else
        {
            orderbook = getValue(this.orderbooks, symbol);
            (orderbook as IOrderBook).reset(snapshot);
        }
        object messageHash = add(add(channel, ":"), marketId);
        callDynamically(client as WebSocketClient, "resolve", new object[] {orderbook, messageHash});
    }

    public async override Task<object> watchTrades(object symbol, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name hollaex#watchTrades
        * @description get the list of most recent trades for a particular symbol
        * @param {string} symbol unified symbol of the market to fetch trades for
        * @param {int} [since] timestamp in ms of the earliest trade to fetch
        * @param {int} [limit] the maximum amount of trades to fetch
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object[]} a list of [trade structures]{@link https://docs.ccxt.com/#/?id=public-trades}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        symbol = getValue(market, "symbol");
        object messageHash = add(add("trade", ":"), getValue(market, "id"));
        object trades = await this.watchPublic(messageHash, parameters);
        if (isTrue(this.newUpdates))
        {
            limit = callDynamically(trades, "getLimit", new object[] {symbol, limit});
        }
        return this.filterBySinceLimit(trades, since, limit, "timestamp", true);
    }

    public virtual void handleTrades(WebSocketClient client, object message)
    {
        //
        //     {
        //         "topic": "trade",
        //         "action": "partial",
        //         "symbol": "btc-usdt",
        //         "data": [
        //             {
        //                 "size": 0.05145,
        //                 "price": 41977.9,
        //                 "side": "buy",
        //                 "timestamp": "2022-04-11T09:40:10.881Z"
        //             },
        //         ]
        //     }
        //
        object channel = this.safeString(message, "topic");
        object marketId = this.safeString(message, "symbol");
        object market = this.safeMarket(marketId);
        object symbol = getValue(market, "symbol");
        object stored = this.safeValue(this.trades, symbol);
        if (isTrue(isEqual(stored, null)))
        {
            object limit = this.safeInteger(this.options, "tradesLimit", 1000);
            stored = new ArrayCache(limit);
            ((IDictionary<string,object>)this.trades)[(string)symbol] = stored;
        }
        object data = this.safeValue(message, "data", new List<object>() {});
        object parsedTrades = this.parseTrades(data, market);
        for (object j = 0; isLessThan(j, getArrayLength(parsedTrades)); postFixIncrement(ref j))
        {
            callDynamically(stored, "append", new object[] {getValue(parsedTrades, j)});
        }
        object messageHash = add(add(channel, ":"), marketId);
        callDynamically(client as WebSocketClient, "resolve", new object[] {stored, messageHash});
        callDynamically(client as WebSocketClient, "resolve", new object[] {stored, channel});
    }

    public async override Task<object> watchMyTrades(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name hollaex#watchMyTrades
        * @description watches information on multiple trades made by the user
        * @param {string} symbol unified market symbol of the market trades were made in
        * @param {int} [since] the earliest time in ms to fetch trades for
        * @param {int} [limit] the maximum number of trade structures to retrieve
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object[]} a list of [trade structures]{@link https://docs.ccxt.com/#/?id=trade-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object messageHash = "usertrade";
        object market = null;
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
            symbol = getValue(market, "symbol");
            messageHash = add(messageHash, add(":", getValue(market, "id")));
        }
        object trades = await this.watchPrivate(messageHash, parameters);
        if (isTrue(this.newUpdates))
        {
            limit = callDynamically(trades, "getLimit", new object[] {symbol, limit});
        }
        return this.filterBySymbolSinceLimit(trades, symbol, since, limit, true);
    }

    public virtual void handleMyTrades(WebSocketClient client, object message, object subscription = null)
    {
        //
        // {
        //     "topic":"usertrade",
        //     "action":"insert",
        //     "user_id":"103",
        //     "symbol":"xht-usdt",
        //     "data":[
        //        {
        //           "size":1,
        //           "side":"buy",
        //           "price":0.24,
        //           "symbol":"xht-usdt",
        //           "timestamp":"2022-05-13T09:30:15.014Z",
        //           "order_id":"6065a66e-e9a4-44a3-9726-4f8fa54b6bb6",
        //           "fee":0.001,
        //           "fee_coin":"xht",
        //           "is_same":true
        //        }
        //     ],
        //     "time":1652434215
        // }
        //
        object channel = this.safeString(message, "topic");
        object rawTrades = this.safeValue(message, "data");
        // usually the first message is an empty array
        // when the user does not have any trades yet
        object dataLength = getArrayLength(rawTrades);
        if (isTrue(isEqual(dataLength, 0)))
        {
            return;
        }
        if (isTrue(isEqual(this.myTrades, null)))
        {
            object limit = this.safeInteger(this.options, "tradesLimit", 1000);
            this.myTrades = new ArrayCache(limit);
        }
        object stored = this.myTrades;
        object marketIds = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(rawTrades)); postFixIncrement(ref i))
        {
            object trade = getValue(rawTrades, i);
            object parsed = this.parseTrade(trade);
            callDynamically(stored, "append", new object[] {parsed});
            object symbol = getValue(trade, "symbol");
            object market = this.market(symbol);
            object marketId = getValue(market, "id");
            ((IDictionary<string,object>)marketIds)[(string)marketId] = true;
        }
        // non-symbol specific
        callDynamically(client as WebSocketClient, "resolve", new object[] {this.myTrades, channel});
        object keys = new List<object>(((IDictionary<string,object>)marketIds).Keys);
        for (object i = 0; isLessThan(i, getArrayLength(keys)); postFixIncrement(ref i))
        {
            object marketId = getValue(keys, i);
            object messageHash = add(add(channel, ":"), marketId);
            callDynamically(client as WebSocketClient, "resolve", new object[] {this.myTrades, messageHash});
        }
    }

    public async override Task<object> watchOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name hollaex#watchOrders
        * @description watches information on multiple orders made by the user
        * @param {string} symbol unified market symbol of the market orders were made in
        * @param {int} [since] the earliest time in ms to fetch orders for
        * @param {int} [limit] the maximum number of order structures to retrieve
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object[]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object messageHash = "order";
        object market = null;
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
            symbol = getValue(market, "symbol");
            messageHash = add(messageHash, add(":", getValue(market, "id")));
        }
        object orders = await this.watchPrivate(messageHash, parameters);
        if (isTrue(this.newUpdates))
        {
            limit = callDynamically(orders, "getLimit", new object[] {symbol, limit});
        }
        return this.filterBySymbolSinceLimit(orders, symbol, since, limit, true);
    }

    public virtual void handleOrder(WebSocketClient client, object message, object subscription = null)
    {
        //
        //     {
        //         "topic": "order",
        //         "action": "insert",
        //         "user_id": 155328,
        //         "symbol": "ltc-usdt",
        //         "data": {
        //             "symbol": "ltc-usdt",
        //             "side": "buy",
        //             "size": 0.05,
        //             "type": "market",
        //             "price": 0,
        //             "fee_structure": { maker: 0.1, taker: 0.1 },
        //             "fee_coin": "ltc",
        //             "id": "ce38fd48-b336-400b-812b-60c636454231",
        //             "created_by": 155328,
        //             "filled": 0.05,
        //             "method": "market",
        //             "created_at": "2022-04-11T14:09:00.760Z",
        //             "updated_at": "2022-04-11T14:09:00.760Z",
        //             "status": "filled"
        //         },
        //         "time": 1649686140
        //     }
        //
        //    {
        //        "topic":"order",
        //        "action":"partial",
        //        "user_id":155328,
        //        "data":[
        //           {
        //              "created_at":"2022-05-13T08:19:07.694Z",
        //              "fee":0,
        //              "meta":{
        //
        //              },
        //              "symbol":"ltc-usdt",
        //              "side":"buy",
        //              "size":0.1,
        //              "type":"limit",
        //              "price":55,
        //              "fee_structure":{
        //                 "maker":0.1,
        //                 "taker":0.1
        //              },
        //              "fee_coin":"ltc",
        //              "id":"d5e77182-ad4c-4ac9-8ce4-a97f9b43e33c",
        //              "created_by":155328,
        //              "filled":0,
        //              "status":"new",
        //              "updated_at":"2022-05-13T08:19:07.694Z",
        //              "stop":null
        //           }
        //        ],
        //        "time":1652430035
        //       }
        //
        object channel = this.safeString(message, "topic");
        object data = this.safeValue(message, "data", new Dictionary<string, object>() {});
        // usually the first message is an empty array
        object dataLength = getArrayLength(data);
        if (isTrue(isEqual(dataLength, 0)))
        {
            return;
        }
        if (isTrue(isEqual(this.orders, null)))
        {
            object limit = this.safeInteger(this.options, "ordersLimit", 1000);
            this.orders = new ArrayCacheBySymbolById(limit);
        }
        object stored = this.orders;
        object rawOrders = null;
        if (!isTrue(((data is IList<object>) || (data.GetType().IsGenericType && data.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>))))))
        {
            rawOrders = new List<object>() {data};
        } else
        {
            rawOrders = data;
        }
        object marketIds = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(rawOrders)); postFixIncrement(ref i))
        {
            object order = getValue(rawOrders, i);
            object parsed = this.parseOrder(order);
            callDynamically(stored, "append", new object[] {parsed});
            object symbol = getValue(order, "symbol");
            object market = this.market(symbol);
            object marketId = getValue(market, "id");
            ((IDictionary<string,object>)marketIds)[(string)marketId] = true;
        }
        // non-symbol specific
        callDynamically(client as WebSocketClient, "resolve", new object[] {this.orders, channel});
        object keys = new List<object>(((IDictionary<string,object>)marketIds).Keys);
        for (object i = 0; isLessThan(i, getArrayLength(keys)); postFixIncrement(ref i))
        {
            object marketId = getValue(keys, i);
            object messageHash = add(add(channel, ":"), marketId);
            callDynamically(client as WebSocketClient, "resolve", new object[] {this.orders, messageHash});
        }
    }

    public async override Task<object> watchBalance(object parameters = null)
    {
        /**
        * @method
        * @name hollaex#watchBalance
        * @description watch balance and get the amount of funds available for trading or funds locked in orders
        * @param {object} [params] extra parameters specific to the exchange API endpoint
        * @returns {object} a [balance structure]{@link https://docs.ccxt.com/#/?id=balance-structure}
        */
        parameters ??= new Dictionary<string, object>();
        object messageHash = "wallet";
        return await this.watchPrivate(messageHash, parameters);
    }

    public virtual void handleBalance(WebSocketClient client, object message)
    {
        //
        //     {
        //         "topic": "wallet",
        //         "action": "partial",
        //         "user_id": 155328,
        //         "data": {
        //             "eth_balance": 0,
        //             "eth_available": 0,
        //             "usdt_balance": 18.94344188,
        //             "usdt_available": 18.94344188,
        //             "ltc_balance": 0.00005,
        //             "ltc_available": 0.00005,
        //         },
        //         "time": 1649687396
        //     }
        //
        object messageHash = this.safeString(message, "topic");
        object data = this.safeValue(message, "data");
        object keys = new List<object>(((IDictionary<string,object>)data).Keys);
        object timestamp = this.safeTimestamp(message, "time");
        ((IDictionary<string,object>)this.balance)["info"] = data;
        ((IDictionary<string,object>)this.balance)["timestamp"] = timestamp;
        ((IDictionary<string,object>)this.balance)["datetime"] = this.iso8601(timestamp);
        for (object i = 0; isLessThan(i, getArrayLength(keys)); postFixIncrement(ref i))
        {
            object key = getValue(keys, i);
            object parts = ((string)key).Split(new [] {((string)"_")}, StringSplitOptions.None).ToList<object>();
            object currencyId = this.safeString(parts, 0);
            object code = this.safeCurrencyCode(currencyId);
            object account = ((bool) isTrue((inOp(this.balance, code)))) ? getValue(this.balance, code) : this.account();
            object second = this.safeString(parts, 1);
            object freeOrTotal = ((bool) isTrue((isEqual(second, "available")))) ? "free" : "total";
            ((IDictionary<string,object>)account)[(string)freeOrTotal] = this.safeString(data, key);
            ((IDictionary<string,object>)this.balance)[(string)code] = account;
        }
        this.balance = this.safeBalance(this.balance);
        callDynamically(client as WebSocketClient, "resolve", new object[] {this.balance, messageHash});
    }

    public async virtual Task<object> watchPublic(object messageHash, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        object url = getValue(getValue(this.urls, "api"), "ws");
        object request = new Dictionary<string, object>() {
            { "op", "subscribe" },
            { "args", new List<object>() {messageHash} },
        };
        object message = this.extend(request, parameters);
        return await this.watch(url, messageHash, message, messageHash);
    }

    public async virtual Task<object> watchPrivate(object messageHash, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        this.checkRequiredCredentials();
        object expires = this.safeString(this.options, "ws-expires");
        if (isTrue(isEqual(expires, null)))
        {
            object timeout = parseInt(((object)(divide(this.timeout, 1000))).ToString());
            expires = this.sum(this.seconds(), timeout);
            expires = ((object)expires).ToString();
            // we need to memoize these values to avoid generating a new url on each method execution
            // that would trigger a new connection on each received message
            ((IDictionary<string,object>)this.options)["ws-expires"] = expires;
        }
        object url = getValue(getValue(this.urls, "api"), "ws");
        object auth = add(add("CONNECT", "/stream"), expires);
        object signature = this.hmac(this.encode(auth), this.encode(this.secret), sha256);
        object authParams = new Dictionary<string, object>() {
            { "api-key", this.apiKey },
            { "api-signature", signature },
            { "api-expires", expires },
        };
        object signedUrl = add(add(url, "?"), this.urlencode(authParams));
        object request = new Dictionary<string, object>() {
            { "op", "subscribe" },
            { "args", new List<object>() {messageHash} },
        };
        object message = this.extend(request, parameters);
        return await this.watch(signedUrl, messageHash, message, messageHash);
    }

    public virtual object handleErrorMessage(WebSocketClient client, object message)
    {
        //
        //     { error: "Bearer or HMAC authentication required" }
        //     { error: "Error: wrong input" }
        //
        object error = this.safeInteger(message, "error");
        try
        {
            if (isTrue(!isEqual(error, null)))
            {
                object feedback = add(add(this.id, " "), this.json(message));
                this.throwExactlyMatchedException(getValue(getValue(this.exceptions, "ws"), "exact"), error, feedback);
            }
        } catch(Exception e)
        {
            if (isTrue(e is AuthenticationError))
            {
                return false;
            }
        }
        return message;
    }

    public override void handleMessage(WebSocketClient client, object message)
    {
        //
        // pong
        //
        //     { message: "pong" }
        //
        // trade
        //
        //     {
        //         "topic": "trade",
        //         "action": "partial",
        //         "symbol": "btc-usdt",
        //         "data": [
        //             {
        //                 "size": 0.05145,
        //                 "price": 41977.9,
        //                 "side": "buy",
        //                 "timestamp": "2022-04-11T09:40:10.881Z"
        //             },
        //         ]
        //     }
        //
        // orderbook
        //
        //     {
        //         "topic": "orderbook",
        //         "action": "partial",
        //         "symbol": "ltc-usdt",
        //         "data": {
        //             "bids": [
        //                 [104.29, 5.2264],
        //                 [103.86,1.3629],
        //                 [101.82,0.5942]
        //             ],
        //             "asks": [
        //                 [104.81,9.5531],
        //                 [105.54,0.6416],
        //                 [106.18,1.4141],
        //             ],
        //             "timestamp": "2022-04-11T10:37:01.227Z"
        //         },
        //         "time": 1649673421
        //     }
        //
        // order
        //
        //     {
        //         "topic": "order",
        //         "action": "insert",
        //         "user_id": 155328,
        //         "symbol": "ltc-usdt",
        //         "data": {
        //             "symbol": "ltc-usdt",
        //             "side": "buy",
        //             "size": 0.05,
        //             "type": "market",
        //             "price": 0,
        //             "fee_structure": { maker: 0.1, taker: 0.1 },
        //             "fee_coin": "ltc",
        //             "id": "ce38fd48-b336-400b-812b-60c636454231",
        //             "created_by": 155328,
        //             "filled": 0.05,
        //             "method": "market",
        //             "created_at": "2022-04-11T14:09:00.760Z",
        //             "updated_at": "2022-04-11T14:09:00.760Z",
        //             "status": "filled"
        //         },
        //         "time": 1649686140
        //     }
        //
        // balance
        //
        //     {
        //         "topic": "wallet",
        //         "action": "partial",
        //         "user_id": 155328,
        //         "data": {
        //             "eth_balance": 0,
        //             "eth_available": 0,
        //             "usdt_balance": 18.94344188,
        //             "usdt_available": 18.94344188,
        //             "ltc_balance": 0.00005,
        //             "ltc_available": 0.00005,
        //         }
        //     }
        //
        if (!isTrue(this.handleErrorMessage(client as WebSocketClient, message)))
        {
            return;
        }
        object content = this.safeString(message, "message");
        if (isTrue(isEqual(content, "pong")))
        {
            this.handlePong(client as WebSocketClient, message);
            return;
        }
        object methods = new Dictionary<string, object>() {
            { "trade", this.handleTrades },
            { "orderbook", this.handleOrderBook },
            { "order", this.handleOrder },
            { "wallet", this.handleBalance },
            { "usertrade", this.handleMyTrades },
        };
        object topic = this.safeValue(message, "topic");
        object method = this.safeValue(methods, topic);
        if (isTrue(!isEqual(method, null)))
        {
            DynamicInvoker.InvokeMethod(method, new object[] { client, message});
        }
    }

    public override object ping(WebSocketClient client)
    {
        // hollaex does not support built-in ws protocol-level ping-pong
        return new Dictionary<string, object>() {
            { "op", "ping" },
        };
    }

    public virtual object handlePong(WebSocketClient client, object message)
    {
        client.lastPong = this.milliseconds();
        return message;
    }

    public override void onError(WebSocketClient client, object error)
    {
        ((IDictionary<string,object>)this.options)["ws-expires"] = null;
        this.onError(client as WebSocketClient, error);
    }

    public override void onClose(WebSocketClient client, object error)
    {
        ((IDictionary<string,object>)this.options)["ws-expires"] = null;
        this.onClose(client as WebSocketClient, error);
    }
}
