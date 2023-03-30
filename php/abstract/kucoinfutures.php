<?php

namespace ccxt\abstract;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


abstract class kucoinfutures extends kucoin {
    public function public_get_timestamp($params = array()) {
        return $this->request('timestamp', 'public', 'GET', $params);
    }
    public function public_get_status($params = array()) {
        return $this->request('status', 'public', 'GET', $params);
    }
    public function public_get_symbols($params = array()) {
        return $this->request('symbols', 'public', 'GET', $params);
    }
    public function public_get_markets($params = array()) {
        return $this->request('markets', 'public', 'GET', $params);
    }
    public function public_get_market_alltickers($params = array()) {
        return $this->request('market/allTickers', 'public', 'GET', $params);
    }
    public function public_get_market_orderbook_level_level_limit($params = array()) {
        return $this->request('market/orderbook/level{level}_{limit}', 'public', 'GET', $params);
    }
    public function public_get_market_orderbook_level2_20($params = array()) {
        return $this->request('market/orderbook/level2_20', 'public', 'GET', $params);
    }
    public function public_get_market_orderbook_level2_100($params = array()) {
        return $this->request('market/orderbook/level2_100', 'public', 'GET', $params);
    }
    public function public_get_market_histories($params = array()) {
        return $this->request('market/histories', 'public', 'GET', $params);
    }
    public function public_get_market_candles($params = array()) {
        return $this->request('market/candles', 'public', 'GET', $params);
    }
    public function public_get_market_stats($params = array()) {
        return $this->request('market/stats', 'public', 'GET', $params);
    }
    public function public_get_currencies($params = array()) {
        return $this->request('currencies', 'public', 'GET', $params);
    }
    public function public_get_currencies_currency($params = array()) {
        return $this->request('currencies/{currency}', 'public', 'GET', $params);
    }
    public function public_get_prices($params = array()) {
        return $this->request('prices', 'public', 'GET', $params);
    }
    public function public_get_mark_price_symbol_current($params = array()) {
        return $this->request('mark-price/{symbol}/current', 'public', 'GET', $params);
    }
    public function public_get_margin_config($params = array()) {
        return $this->request('margin/config', 'public', 'GET', $params);
    }
    public function public_get_margin_trade_last($params = array()) {
        return $this->request('margin/trade/last', 'public', 'GET', $params);
    }
    public function public_post_bullet_public($params = array()) {
        return $this->request('bullet-public', 'public', 'POST', $params);
    }
    public function private_get_market_orderbook_level_level($params = array()) {
        return $this->request('market/orderbook/level{level}', 'private', 'GET', $params);
    }
    public function private_get_market_orderbook_level2($params = array()) {
        return $this->request('market/orderbook/level2', 'private', 'GET', $params);
    }
    public function private_get_market_orderbook_level3($params = array()) {
        return $this->request('market/orderbook/level3', 'private', 'GET', $params);
    }
    public function private_get_accounts($params = array()) {
        return $this->request('accounts', 'private', 'GET', $params);
    }
    public function private_get_accounts_accountid($params = array()) {
        return $this->request('accounts/{accountId}', 'private', 'GET', $params);
    }
    public function private_get_accounts_ledgers($params = array()) {
        return $this->request('accounts/ledgers', 'private', 'GET', $params);
    }
    public function private_get_accounts_accountid_holds($params = array()) {
        return $this->request('accounts/{accountId}/holds', 'private', 'GET', $params);
    }
    public function private_get_accounts_transferable($params = array()) {
        return $this->request('accounts/transferable', 'private', 'GET', $params);
    }
    public function private_get_base_fee($params = array()) {
        return $this->request('base-fee', 'private', 'GET', $params);
    }
    public function private_get_sub_user($params = array()) {
        return $this->request('sub/user', 'private', 'GET', $params);
    }
    public function private_get_user_info($params = array()) {
        return $this->request('user-info', 'private', 'GET', $params);
    }
    public function private_get_sub_api_key($params = array()) {
        return $this->request('sub/api-key', 'private', 'GET', $params);
    }
    public function private_get_sub_accounts($params = array()) {
        return $this->request('sub-accounts', 'private', 'GET', $params);
    }
    public function private_get_sub_accounts_subuserid($params = array()) {
        return $this->request('sub-accounts/{subUserId}', 'private', 'GET', $params);
    }
    public function private_get_deposit_addresses($params = array()) {
        return $this->request('deposit-addresses', 'private', 'GET', $params);
    }
    public function private_get_deposits($params = array()) {
        return $this->request('deposits', 'private', 'GET', $params);
    }
    public function private_get_hist_deposits($params = array()) {
        return $this->request('hist-deposits', 'private', 'GET', $params);
    }
    public function private_get_hist_withdrawals($params = array()) {
        return $this->request('hist-withdrawals', 'private', 'GET', $params);
    }
    public function private_get_withdrawals($params = array()) {
        return $this->request('withdrawals', 'private', 'GET', $params);
    }
    public function private_get_withdrawals_quotas($params = array()) {
        return $this->request('withdrawals/quotas', 'private', 'GET', $params);
    }
    public function private_get_orders($params = array()) {
        return $this->request('orders', 'private', 'GET', $params);
    }
    public function private_get_order_client_order_clientoid($params = array()) {
        return $this->request('order/client-order/{clientOid}', 'private', 'GET', $params);
    }
    public function private_get_orders_orderid($params = array()) {
        return $this->request('orders/{orderId}', 'private', 'GET', $params);
    }
    public function private_get_limit_orders($params = array()) {
        return $this->request('limit/orders', 'private', 'GET', $params);
    }
    public function private_get_fills($params = array()) {
        return $this->request('fills', 'private', 'GET', $params);
    }
    public function private_get_limit_fills($params = array()) {
        return $this->request('limit/fills', 'private', 'GET', $params);
    }
    public function private_get_isolated_accounts($params = array()) {
        return $this->request('isolated/accounts', 'private', 'GET', $params);
    }
    public function private_get_isolated_account_symbol($params = array()) {
        return $this->request('isolated/account/{symbol}', 'private', 'GET', $params);
    }
    public function private_get_isolated_borrow_outstanding($params = array()) {
        return $this->request('isolated/borrow/outstanding', 'private', 'GET', $params);
    }
    public function private_get_isolated_borrow_repaid($params = array()) {
        return $this->request('isolated/borrow/repaid', 'private', 'GET', $params);
    }
    public function private_get_isolated_symbols($params = array()) {
        return $this->request('isolated/symbols', 'private', 'GET', $params);
    }
    public function private_get_margin_account($params = array()) {
        return $this->request('margin/account', 'private', 'GET', $params);
    }
    public function private_get_margin_borrow($params = array()) {
        return $this->request('margin/borrow', 'private', 'GET', $params);
    }
    public function private_get_margin_borrow_outstanding($params = array()) {
        return $this->request('margin/borrow/outstanding', 'private', 'GET', $params);
    }
    public function private_get_margin_borrow_repaid($params = array()) {
        return $this->request('margin/borrow/repaid', 'private', 'GET', $params);
    }
    public function private_get_margin_lend_active($params = array()) {
        return $this->request('margin/lend/active', 'private', 'GET', $params);
    }
    public function private_get_margin_lend_done($params = array()) {
        return $this->request('margin/lend/done', 'private', 'GET', $params);
    }
    public function private_get_margin_lend_trade_unsettled($params = array()) {
        return $this->request('margin/lend/trade/unsettled', 'private', 'GET', $params);
    }
    public function private_get_margin_lend_trade_settled($params = array()) {
        return $this->request('margin/lend/trade/settled', 'private', 'GET', $params);
    }
    public function private_get_margin_lend_assets($params = array()) {
        return $this->request('margin/lend/assets', 'private', 'GET', $params);
    }
    public function private_get_margin_market($params = array()) {
        return $this->request('margin/market', 'private', 'GET', $params);
    }
    public function private_get_stop_order_orderid($params = array()) {
        return $this->request('stop-order/{orderId}', 'private', 'GET', $params);
    }
    public function private_get_stop_order($params = array()) {
        return $this->request('stop-order', 'private', 'GET', $params);
    }
    public function private_get_stop_order_queryorderbyclientoid($params = array()) {
        return $this->request('stop-order/queryOrderByClientOid', 'private', 'GET', $params);
    }
    public function private_get_trade_fees($params = array()) {
        return $this->request('trade-fees', 'private', 'GET', $params);
    }
    public function private_post_accounts($params = array()) {
        return $this->request('accounts', 'private', 'POST', $params);
    }
    public function private_post_accounts_inner_transfer($params = array()) {
        return $this->request('accounts/inner-transfer', 'private', 'POST', $params);
    }
    public function private_post_accounts_sub_transfer($params = array()) {
        return $this->request('accounts/sub-transfer', 'private', 'POST', $params);
    }
    public function private_post_deposit_addresses($params = array()) {
        return $this->request('deposit-addresses', 'private', 'POST', $params);
    }
    public function private_post_withdrawals($params = array()) {
        return $this->request('withdrawals', 'private', 'POST', $params);
    }
    public function private_post_orders($params = array()) {
        return $this->request('orders', 'private', 'POST', $params);
    }
    public function private_post_orders_multi($params = array()) {
        return $this->request('orders/multi', 'private', 'POST', $params);
    }
    public function private_post_isolated_borrow($params = array()) {
        return $this->request('isolated/borrow', 'private', 'POST', $params);
    }
    public function private_post_isolated_repay_all($params = array()) {
        return $this->request('isolated/repay/all', 'private', 'POST', $params);
    }
    public function private_post_isolated_repay_single($params = array()) {
        return $this->request('isolated/repay/single', 'private', 'POST', $params);
    }
    public function private_post_margin_borrow($params = array()) {
        return $this->request('margin/borrow', 'private', 'POST', $params);
    }
    public function private_post_margin_order($params = array()) {
        return $this->request('margin/order', 'private', 'POST', $params);
    }
    public function private_post_margin_repay_all($params = array()) {
        return $this->request('margin/repay/all', 'private', 'POST', $params);
    }
    public function private_post_margin_repay_single($params = array()) {
        return $this->request('margin/repay/single', 'private', 'POST', $params);
    }
    public function private_post_margin_lend($params = array()) {
        return $this->request('margin/lend', 'private', 'POST', $params);
    }
    public function private_post_margin_toggle_auto_lend($params = array()) {
        return $this->request('margin/toggle-auto-lend', 'private', 'POST', $params);
    }
    public function private_post_bullet_private($params = array()) {
        return $this->request('bullet-private', 'private', 'POST', $params);
    }
    public function private_post_stop_order($params = array()) {
        return $this->request('stop-order', 'private', 'POST', $params);
    }
    public function private_post_sub_user($params = array()) {
        return $this->request('sub/user', 'private', 'POST', $params);
    }
    public function private_post_sub_api_key($params = array()) {
        return $this->request('sub/api-key', 'private', 'POST', $params);
    }
    public function private_post_sub_api_key_update($params = array()) {
        return $this->request('sub/api-key/update', 'private', 'POST', $params);
    }
    public function private_delete_withdrawals_withdrawalid($params = array()) {
        return $this->request('withdrawals/{withdrawalId}', 'private', 'DELETE', $params);
    }
    public function private_delete_orders($params = array()) {
        return $this->request('orders', 'private', 'DELETE', $params);
    }
    public function private_delete_order_client_order_clientoid($params = array()) {
        return $this->request('order/client-order/{clientOid}', 'private', 'DELETE', $params);
    }
    public function private_delete_orders_orderid($params = array()) {
        return $this->request('orders/{orderId}', 'private', 'DELETE', $params);
    }
    public function private_delete_margin_lend_orderid($params = array()) {
        return $this->request('margin/lend/{orderId}', 'private', 'DELETE', $params);
    }
    public function private_delete_stop_order_cancelorderbyclientoid($params = array()) {
        return $this->request('stop-order/cancelOrderByClientOid', 'private', 'DELETE', $params);
    }
    public function private_delete_stop_order_orderid($params = array()) {
        return $this->request('stop-order/{orderId}', 'private', 'DELETE', $params);
    }
    public function private_delete_stop_order_cancel($params = array()) {
        return $this->request('stop-order/cancel', 'private', 'DELETE', $params);
    }
    public function private_delete_sub_api_key($params = array()) {
        return $this->request('sub/api-key', 'private', 'DELETE', $params);
    }
    public function futurespublic_get_contracts_active($params = array()) {
        return $this->request('contracts/active', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_contracts_symbol($params = array()) {
        return $this->request('contracts/{symbol}', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_ticker($params = array()) {
        return $this->request('ticker', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_level2_snapshot($params = array()) {
        return $this->request('level2/snapshot', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_level2_depth20($params = array()) {
        return $this->request('level2/depth20', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_level2_depth100($params = array()) {
        return $this->request('level2/depth100', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_level2_message_query($params = array()) {
        return $this->request('level2/message/query', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_level3_message_query($params = array()) {
        return $this->request('level3/message/query', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_level3_snapshot($params = array()) {
        return $this->request('level3/snapshot', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_trade_history($params = array()) {
        return $this->request('trade/history', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_interest_query($params = array()) {
        return $this->request('interest/query', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_index_query($params = array()) {
        return $this->request('index/query', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_mark_price_symbol_current($params = array()) {
        return $this->request('mark-price/{symbol}/current', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_premium_query($params = array()) {
        return $this->request('premium/query', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_funding_rate_symbol_current($params = array()) {
        return $this->request('funding-rate/{symbol}/current', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_timestamp($params = array()) {
        return $this->request('timestamp', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_status($params = array()) {
        return $this->request('status', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_kline_query($params = array()) {
        return $this->request('kline/query', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_contracts_risk_limit_symbol($params = array()) {
        return $this->request('contracts/risk-limit/{symbol}', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_get_level2_depth_limit($params = array()) {
        return $this->request('level2/depth{limit}', 'futuresPublic', 'GET', $params);
    }
    public function futurespublic_post_bullet_public($params = array()) {
        return $this->request('bullet-public', 'futuresPublic', 'POST', $params);
    }
    public function futuresprivate_get_account_overview($params = array()) {
        return $this->request('account-overview', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_transaction_history($params = array()) {
        return $this->request('transaction-history', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_deposit_address($params = array()) {
        return $this->request('deposit-address', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_deposit_list($params = array()) {
        return $this->request('deposit-list', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_withdrawals_quotas($params = array()) {
        return $this->request('withdrawals/quotas', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_withdrawal_list($params = array()) {
        return $this->request('withdrawal-list', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_transfer_list($params = array()) {
        return $this->request('transfer-list', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_orders($params = array()) {
        return $this->request('orders', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_stoporders($params = array()) {
        return $this->request('stopOrders', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_recentdoneorders($params = array()) {
        return $this->request('recentDoneOrders', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_orders_orderid($params = array()) {
        return $this->request('orders/{orderId}', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_orders_byclientoid($params = array()) {
        return $this->request('orders/byClientOid', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_fills($params = array()) {
        return $this->request('fills', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_recentfills($params = array()) {
        return $this->request('recentFills', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_openorderstatistics($params = array()) {
        return $this->request('openOrderStatistics', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_position($params = array()) {
        return $this->request('position', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_positions($params = array()) {
        return $this->request('positions', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_get_funding_history($params = array()) {
        return $this->request('funding-history', 'futuresPrivate', 'GET', $params);
    }
    public function futuresprivate_post_withdrawals($params = array()) {
        return $this->request('withdrawals', 'futuresPrivate', 'POST', $params);
    }
    public function futuresprivate_post_transfer_out($params = array()) {
        return $this->request('transfer-out', 'futuresPrivate', 'POST', $params);
    }
    public function futuresprivate_post_orders($params = array()) {
        return $this->request('orders', 'futuresPrivate', 'POST', $params);
    }
    public function futuresprivate_post_position_margin_auto_deposit_status($params = array()) {
        return $this->request('position/margin/auto-deposit-status', 'futuresPrivate', 'POST', $params);
    }
    public function futuresprivate_post_position_margin_deposit_margin($params = array()) {
        return $this->request('position/margin/deposit-margin', 'futuresPrivate', 'POST', $params);
    }
    public function futuresprivate_post_bullet_private($params = array()) {
        return $this->request('bullet-private', 'futuresPrivate', 'POST', $params);
    }
    public function futuresprivate_delete_withdrawals_withdrawalid($params = array()) {
        return $this->request('withdrawals/{withdrawalId}', 'futuresPrivate', 'DELETE', $params);
    }
    public function futuresprivate_delete_cancel_transfer_out($params = array()) {
        return $this->request('cancel/transfer-out', 'futuresPrivate', 'DELETE', $params);
    }
    public function futuresprivate_delete_orders_orderid($params = array()) {
        return $this->request('orders/{orderId}', 'futuresPrivate', 'DELETE', $params);
    }
    public function futuresprivate_delete_orders($params = array()) {
        return $this->request('orders', 'futuresPrivate', 'DELETE', $params);
    }
    public function futuresprivate_delete_stoporders($params = array()) {
        return $this->request('stopOrders', 'futuresPrivate', 'DELETE', $params);
    }
    public function webfront_get_contract_symbol_funding_rates($params = array()) {
        return $this->request('contract/{symbol}/funding-rates', 'webFront', 'GET', $params);
    }
}