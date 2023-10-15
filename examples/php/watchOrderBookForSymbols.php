<?php
namespace ccxt;
include_once (__DIR__.'/../../ccxt.php');
// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -----------------------------------------------------------------------------

error_reporting(E_ALL | E_STRICT);
date_default_timezone_set('UTC');

use ccxt\Precise;
use React\Async;
use React\Promise;


// AUTO-TRANSPILE //
function example() {
    return Async\async(function () {
        $binance = new \ccxt\pro\binance(array());
        $symbol = ['BTC/USDT', 'ETH/USDT', 'DOGE/USDT'];
        while (true) {
            $orderbook = Async\await($binance->watch_order_book_for_symbols($symbol));
            var_dump($orderbook['symbol'], $orderbook['asks'][0], $orderbook['bids'][0]);
        }
    }) ();
}


Async\await(example());
