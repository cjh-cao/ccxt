<?php

namespace ccxt\abstract;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


abstract class buda extends \ccxt\Exchange {
    public function public_get_pairs($params = array()) {
        return $this->request('pairs', 'public', 'GET', $params);
    }
    public function public_get_markets($params = array()) {
        return $this->request('markets', 'public', 'GET', $params);
    }
    public function public_get_currencies($params = array()) {
        return $this->request('currencies', 'public', 'GET', $params);
    }
    public function public_get_markets_market($params = array()) {
        return $this->request('markets/{market}', 'public', 'GET', $params);
    }
    public function public_get_markets_market_ticker($params = array()) {
        return $this->request('markets/{market}/ticker', 'public', 'GET', $params);
    }
    public function public_get_markets_market_volume($params = array()) {
        return $this->request('markets/{market}/volume', 'public', 'GET', $params);
    }
    public function public_get_markets_market_order_book($params = array()) {
        return $this->request('markets/{market}/order_book', 'public', 'GET', $params);
    }
    public function public_get_markets_market_trades($params = array()) {
        return $this->request('markets/{market}/trades', 'public', 'GET', $params);
    }
    public function public_get_currencies_currency_fees_deposit($params = array()) {
        return $this->request('currencies/{currency}/fees/deposit', 'public', 'GET', $params);
    }
    public function public_get_currencies_currency_fees_withdrawal($params = array()) {
        return $this->request('currencies/{currency}/fees/withdrawal', 'public', 'GET', $params);
    }
    public function public_get_tv_history($params = array()) {
        return $this->request('tv/history', 'public', 'GET', $params);
    }
    public function public_post_markets_market_quotations($params = array()) {
        return $this->request('markets/{market}/quotations', 'public', 'POST', $params);
    }
    public function private_get_balances($params = array()) {
        return $this->request('balances', 'private', 'GET', $params);
    }
    public function private_get_balances_currency($params = array()) {
        return $this->request('balances/{currency}', 'private', 'GET', $params);
    }
    public function private_get_currencies_currency_balances($params = array()) {
        return $this->request('currencies/{currency}/balances', 'private', 'GET', $params);
    }
    public function private_get_orders($params = array()) {
        return $this->request('orders', 'private', 'GET', $params);
    }
    public function private_get_orders_id($params = array()) {
        return $this->request('orders/{id}', 'private', 'GET', $params);
    }
    public function private_get_markets_market_orders($params = array()) {
        return $this->request('markets/{market}/orders', 'private', 'GET', $params);
    }
    public function private_get_deposits($params = array()) {
        return $this->request('deposits', 'private', 'GET', $params);
    }
    public function private_get_currencies_currency_deposits($params = array()) {
        return $this->request('currencies/{currency}/deposits', 'private', 'GET', $params);
    }
    public function private_get_withdrawals($params = array()) {
        return $this->request('withdrawals', 'private', 'GET', $params);
    }
    public function private_get_currencies_currency_withdrawals($params = array()) {
        return $this->request('currencies/{currency}/withdrawals', 'private', 'GET', $params);
    }
    public function private_get_currencies_currency_receive_addresses($params = array()) {
        return $this->request('currencies/{currency}/receive_addresses', 'private', 'GET', $params);
    }
    public function private_get_currencies_currency_receive_addresses_id($params = array()) {
        return $this->request('currencies/{currency}/receive_addresses/{id}', 'private', 'GET', $params);
    }
    public function private_post_markets_market_orders($params = array()) {
        return $this->request('markets/{market}/orders', 'private', 'POST', $params);
    }
    public function private_post_currencies_currency_deposits($params = array()) {
        return $this->request('currencies/{currency}/deposits', 'private', 'POST', $params);
    }
    public function private_post_currencies_currency_withdrawals($params = array()) {
        return $this->request('currencies/{currency}/withdrawals', 'private', 'POST', $params);
    }
    public function private_post_currencies_currency_simulated_withdrawals($params = array()) {
        return $this->request('currencies/{currency}/simulated_withdrawals', 'private', 'POST', $params);
    }
    public function private_post_currencies_currency_receive_addresses($params = array()) {
        return $this->request('currencies/{currency}/receive_addresses', 'private', 'POST', $params);
    }
    public function private_put_orders_id($params = array()) {
        return $this->request('orders/{id}', 'private', 'PUT', $params);
    }
}