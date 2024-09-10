// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

import { implicitReturnType } from '../base/types.js';
import _kucoin from '../kucoin.js';

interface kucoin {
    publicGetCurrencies (params?: {}): Promise<implicitReturnType>;
    publicGetCurrenciesCurrency (params?: {}): Promise<implicitReturnType>;
    publicGetSymbols (params?: {}): Promise<implicitReturnType>;
    publicGetMarketOrderbookLevel1 (params?: {}): Promise<implicitReturnType>;
    publicGetMarketAllTickers (params?: {}): Promise<implicitReturnType>;
    publicGetMarketStats (params?: {}): Promise<implicitReturnType>;
    publicGetMarkets (params?: {}): Promise<implicitReturnType>;
    publicGetMarketOrderbookLevelLevelLimit (params?: {}): Promise<implicitReturnType>;
    publicGetMarketOrderbookLevel220 (params?: {}): Promise<implicitReturnType>;
    publicGetMarketOrderbookLevel2100 (params?: {}): Promise<implicitReturnType>;
    publicGetMarketHistories (params?: {}): Promise<implicitReturnType>;
    publicGetMarketCandles (params?: {}): Promise<implicitReturnType>;
    publicGetPrices (params?: {}): Promise<implicitReturnType>;
    publicGetTimestamp (params?: {}): Promise<implicitReturnType>;
    publicGetStatus (params?: {}): Promise<implicitReturnType>;
    publicGetMarkPriceSymbolCurrent (params?: {}): Promise<implicitReturnType>;
    publicGetMarkPriceAllSymbols (params?: {}): Promise<implicitReturnType>;
    publicGetMarginConfig (params?: {}): Promise<implicitReturnType>;
    publicPostBulletPublic (params?: {}): Promise<implicitReturnType>;
    privateGetUserInfo (params?: {}): Promise<implicitReturnType>;
    privateGetAccounts (params?: {}): Promise<implicitReturnType>;
    privateGetAccountsAccountId (params?: {}): Promise<implicitReturnType>;
    privateGetAccountsLedgers (params?: {}): Promise<implicitReturnType>;
    privateGetHfAccountsLedgers (params?: {}): Promise<implicitReturnType>;
    privateGetHfMarginAccountLedgers (params?: {}): Promise<implicitReturnType>;
    privateGetTransactionHistory (params?: {}): Promise<implicitReturnType>;
    privateGetSubUser (params?: {}): Promise<implicitReturnType>;
    privateGetSubAccountsSubUserId (params?: {}): Promise<implicitReturnType>;
    privateGetSubAccounts (params?: {}): Promise<implicitReturnType>;
    privateGetSubApiKey (params?: {}): Promise<implicitReturnType>;
    privateGetMarginAccount (params?: {}): Promise<implicitReturnType>;
    privateGetMarginAccounts (params?: {}): Promise<implicitReturnType>;
    privateGetIsolatedAccounts (params?: {}): Promise<implicitReturnType>;
    privateGetDepositAddresses (params?: {}): Promise<implicitReturnType>;
    privateGetDeposits (params?: {}): Promise<implicitReturnType>;
    privateGetHistDeposits (params?: {}): Promise<implicitReturnType>;
    privateGetWithdrawals (params?: {}): Promise<implicitReturnType>;
    privateGetHistWithdrawals (params?: {}): Promise<implicitReturnType>;
    privateGetWithdrawalsQuotas (params?: {}): Promise<implicitReturnType>;
    privateGetAccountsTransferable (params?: {}): Promise<implicitReturnType>;
    privateGetTransferList (params?: {}): Promise<implicitReturnType>;
    privateGetBaseFee (params?: {}): Promise<implicitReturnType>;
    privateGetTradeFees (params?: {}): Promise<implicitReturnType>;
    privateGetMarketOrderbookLevelLevel (params?: {}): Promise<implicitReturnType>;
    privateGetMarketOrderbookLevel2 (params?: {}): Promise<implicitReturnType>;
    privateGetMarketOrderbookLevel3 (params?: {}): Promise<implicitReturnType>;
    privateGetHfOrdersActive (params?: {}): Promise<implicitReturnType>;
    privateGetHfOrdersActiveSymbols (params?: {}): Promise<implicitReturnType>;
    privateGetHfMarginOrderActiveSymbols (params?: {}): Promise<implicitReturnType>;
    privateGetHfOrdersDone (params?: {}): Promise<implicitReturnType>;
    privateGetHfOrdersOrderId (params?: {}): Promise<implicitReturnType>;
    privateGetHfOrdersClientOrderClientOid (params?: {}): Promise<implicitReturnType>;
    privateGetHfOrdersDeadCancelAllQuery (params?: {}): Promise<implicitReturnType>;
    privateGetHfFills (params?: {}): Promise<implicitReturnType>;
    privateGetOrders (params?: {}): Promise<implicitReturnType>;
    privateGetLimitOrders (params?: {}): Promise<implicitReturnType>;
    privateGetOrdersOrderId (params?: {}): Promise<implicitReturnType>;
    privateGetOrderClientOrderClientOid (params?: {}): Promise<implicitReturnType>;
    privateGetFills (params?: {}): Promise<implicitReturnType>;
    privateGetLimitFills (params?: {}): Promise<implicitReturnType>;
    privateGetStopOrder (params?: {}): Promise<implicitReturnType>;
    privateGetStopOrderOrderId (params?: {}): Promise<implicitReturnType>;
    privateGetStopOrderQueryOrderByClientOid (params?: {}): Promise<implicitReturnType>;
    privateGetOcoOrderOrderId (params?: {}): Promise<implicitReturnType>;
    privateGetOcoOrderDetailsOrderId (params?: {}): Promise<implicitReturnType>;
    privateGetOcoClientOrderClientOid (params?: {}): Promise<implicitReturnType>;
    privateGetOcoOrders (params?: {}): Promise<implicitReturnType>;
    privateGetHfMarginOrdersActive (params?: {}): Promise<implicitReturnType>;
    privateGetHfMarginOrdersDone (params?: {}): Promise<implicitReturnType>;
    privateGetHfMarginOrdersOrderId (params?: {}): Promise<implicitReturnType>;
    privateGetHfMarginOrdersClientOrderClientOid (params?: {}): Promise<implicitReturnType>;
    privateGetHfMarginFills (params?: {}): Promise<implicitReturnType>;
    privateGetEtfInfo (params?: {}): Promise<implicitReturnType>;
    privateGetMarginCurrencies (params?: {}): Promise<implicitReturnType>;
    privateGetRiskLimitStrategy (params?: {}): Promise<implicitReturnType>;
    privateGetIsolatedSymbols (params?: {}): Promise<implicitReturnType>;
    privateGetMarginSymbols (params?: {}): Promise<implicitReturnType>;
    privateGetIsolatedAccountSymbol (params?: {}): Promise<implicitReturnType>;
    privateGetMarginBorrow (params?: {}): Promise<implicitReturnType>;
    privateGetMarginRepay (params?: {}): Promise<implicitReturnType>;
    privateGetMarginInterest (params?: {}): Promise<implicitReturnType>;
    privateGetProjectList (params?: {}): Promise<implicitReturnType>;
    privateGetProjectMarketInterestRate (params?: {}): Promise<implicitReturnType>;
    privateGetRedeemOrders (params?: {}): Promise<implicitReturnType>;
    privateGetPurchaseOrders (params?: {}): Promise<implicitReturnType>;
    privateGetBrokerApiRebaseDownload (params?: {}): Promise<implicitReturnType>;
    privateGetMigrateUserAccountStatus (params?: {}): Promise<implicitReturnType>;
    privateGetAffiliateInviterStatistics (params?: {}): Promise<implicitReturnType>;
    privatePostSubUserCreated (params?: {}): Promise<implicitReturnType>;
    privatePostSubApiKey (params?: {}): Promise<implicitReturnType>;
    privatePostSubApiKeyUpdate (params?: {}): Promise<implicitReturnType>;
    privatePostDepositAddresses (params?: {}): Promise<implicitReturnType>;
    privatePostWithdrawals (params?: {}): Promise<implicitReturnType>;
    privatePostAccountsUniversalTransfer (params?: {}): Promise<implicitReturnType>;
    privatePostAccountsSubTransfer (params?: {}): Promise<implicitReturnType>;
    privatePostAccountsInnerTransfer (params?: {}): Promise<implicitReturnType>;
    privatePostTransferOut (params?: {}): Promise<implicitReturnType>;
    privatePostTransferIn (params?: {}): Promise<implicitReturnType>;
    privatePostHfOrders (params?: {}): Promise<implicitReturnType>;
    privatePostHfOrdersTest (params?: {}): Promise<implicitReturnType>;
    privatePostHfOrdersSync (params?: {}): Promise<implicitReturnType>;
    privatePostHfOrdersMulti (params?: {}): Promise<implicitReturnType>;
    privatePostHfOrdersMultiSync (params?: {}): Promise<implicitReturnType>;
    privatePostHfOrdersAlter (params?: {}): Promise<implicitReturnType>;
    privatePostHfOrdersDeadCancelAll (params?: {}): Promise<implicitReturnType>;
    privatePostOrders (params?: {}): Promise<implicitReturnType>;
    privatePostOrdersTest (params?: {}): Promise<implicitReturnType>;
    privatePostOrdersMulti (params?: {}): Promise<implicitReturnType>;
    privatePostStopOrder (params?: {}): Promise<implicitReturnType>;
    privatePostOcoOrder (params?: {}): Promise<implicitReturnType>;
    privatePostHfMarginOrder (params?: {}): Promise<implicitReturnType>;
    privatePostHfMarginOrderTest (params?: {}): Promise<implicitReturnType>;
    privatePostMarginOrder (params?: {}): Promise<implicitReturnType>;
    privatePostMarginOrderTest (params?: {}): Promise<implicitReturnType>;
    privatePostMarginBorrow (params?: {}): Promise<implicitReturnType>;
    privatePostMarginRepay (params?: {}): Promise<implicitReturnType>;
    privatePostPurchase (params?: {}): Promise<implicitReturnType>;
    privatePostRedeem (params?: {}): Promise<implicitReturnType>;
    privatePostLendPurchaseUpdate (params?: {}): Promise<implicitReturnType>;
    privatePostBulletPrivate (params?: {}): Promise<implicitReturnType>;
    privatePostPositionUpdateUserLeverage (params?: {}): Promise<implicitReturnType>;
    privateDeleteSubApiKey (params?: {}): Promise<implicitReturnType>;
    privateDeleteWithdrawalsWithdrawalId (params?: {}): Promise<implicitReturnType>;
    privateDeleteHfOrdersOrderId (params?: {}): Promise<implicitReturnType>;
    privateDeleteHfOrdersSyncOrderId (params?: {}): Promise<implicitReturnType>;
    privateDeleteHfOrdersClientOrderClientOid (params?: {}): Promise<implicitReturnType>;
    privateDeleteHfOrdersSyncClientOrderClientOid (params?: {}): Promise<implicitReturnType>;
    privateDeleteHfOrdersCancelOrderId (params?: {}): Promise<implicitReturnType>;
    privateDeleteHfOrders (params?: {}): Promise<implicitReturnType>;
    privateDeleteHfOrdersCancelAll (params?: {}): Promise<implicitReturnType>;
    privateDeleteOrdersOrderId (params?: {}): Promise<implicitReturnType>;
    privateDeleteOrderClientOrderClientOid (params?: {}): Promise<implicitReturnType>;
    privateDeleteOrders (params?: {}): Promise<implicitReturnType>;
    privateDeleteStopOrderOrderId (params?: {}): Promise<implicitReturnType>;
    privateDeleteStopOrderCancelOrderByClientOid (params?: {}): Promise<implicitReturnType>;
    privateDeleteStopOrderCancel (params?: {}): Promise<implicitReturnType>;
    privateDeleteOcoOrderOrderId (params?: {}): Promise<implicitReturnType>;
    privateDeleteOcoClientOrderClientOid (params?: {}): Promise<implicitReturnType>;
    privateDeleteOcoOrders (params?: {}): Promise<implicitReturnType>;
    privateDeleteHfMarginOrdersOrderId (params?: {}): Promise<implicitReturnType>;
    privateDeleteHfMarginOrdersClientOrderClientOid (params?: {}): Promise<implicitReturnType>;
    privateDeleteHfMarginOrders (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetContractsActive (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetContractsSymbol (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetTicker (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetLevel2Snapshot (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetLevel2Depth20 (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetLevel2Depth100 (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetTradeHistory (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetKlineQuery (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetInterestQuery (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetIndexQuery (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetMarkPriceSymbolCurrent (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetPremiumQuery (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetTradeStatistics (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetFundingRateSymbolCurrent (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetContractFundingRates (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetTimestamp (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetStatus (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetLevel2MessageQuery (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetContractsRiskLimitSymbol (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetAllTickers (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetLevel2DepthLimit (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetLevel3MessageQuery (params?: {}): Promise<implicitReturnType>;
    futuresPublicGetLevel3Snapshot (params?: {}): Promise<implicitReturnType>;
    futuresPublicPostBulletPublic (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetTransactionHistory (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetAccountOverview (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetAccountOverviewAll (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetTransferList (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetOrders (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetStopOrders (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetRecentDoneOrders (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetOrdersOrderId (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetOrdersByClientOid (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetFills (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetRecentFills (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetOpenOrderStatistics (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetPosition (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetPositions (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetMarginMaxWithdrawMargin (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetContractsRiskLimitSymbol (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetFundingHistory (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetDepositAddress (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetDepositList (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetWithdrawalsQuotas (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetWithdrawalList (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetSubApiKey (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetTradeStatistics (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetTradeFees (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetHistoryPositions (params?: {}): Promise<implicitReturnType>;
    futuresPrivateGetGetMaxOpenSize (params?: {}): Promise<implicitReturnType>;
    futuresPrivatePostTransferOut (params?: {}): Promise<implicitReturnType>;
    futuresPrivatePostTransferIn (params?: {}): Promise<implicitReturnType>;
    futuresPrivatePostOrders (params?: {}): Promise<implicitReturnType>;
    futuresPrivatePostOrdersTest (params?: {}): Promise<implicitReturnType>;
    futuresPrivatePostOrdersMulti (params?: {}): Promise<implicitReturnType>;
    futuresPrivatePostPositionMarginAutoDepositStatus (params?: {}): Promise<implicitReturnType>;
    futuresPrivatePostMarginWithdrawMargin (params?: {}): Promise<implicitReturnType>;
    futuresPrivatePostPositionMarginDepositMargin (params?: {}): Promise<implicitReturnType>;
    futuresPrivatePostPositionRiskLimitLevelChange (params?: {}): Promise<implicitReturnType>;
    futuresPrivatePostBulletPrivate (params?: {}): Promise<implicitReturnType>;
    futuresPrivatePostWithdrawals (params?: {}): Promise<implicitReturnType>;
    futuresPrivatePostSubApiKey (params?: {}): Promise<implicitReturnType>;
    futuresPrivatePostSubApiKeyUpdate (params?: {}): Promise<implicitReturnType>;
    futuresPrivateDeleteOrdersOrderId (params?: {}): Promise<implicitReturnType>;
    futuresPrivateDeleteOrdersClientOrderClientOid (params?: {}): Promise<implicitReturnType>;
    futuresPrivateDeleteOrders (params?: {}): Promise<implicitReturnType>;
    futuresPrivateDeleteStopOrders (params?: {}): Promise<implicitReturnType>;
    futuresPrivateDeleteWithdrawalsWithdrawalId (params?: {}): Promise<implicitReturnType>;
    futuresPrivateDeleteCancelTransferOut (params?: {}): Promise<implicitReturnType>;
    futuresPrivateDeleteSubApiKey (params?: {}): Promise<implicitReturnType>;
    webExchangeGetCurrencyCurrencyChainInfo (params?: {}): Promise<implicitReturnType>;
    webExchangeGetContractSymbolFundingRates (params?: {}): Promise<implicitReturnType>;
    brokerGetBrokerNdInfo (params?: {}): Promise<implicitReturnType>;
    brokerGetBrokerNdAccount (params?: {}): Promise<implicitReturnType>;
    brokerGetBrokerNdAccountApikey (params?: {}): Promise<implicitReturnType>;
    brokerGetBrokerNdRebaseDownload (params?: {}): Promise<implicitReturnType>;
    brokerGetAssetNdbrokerDepositList (params?: {}): Promise<implicitReturnType>;
    brokerGetBrokerNdTransferDetail (params?: {}): Promise<implicitReturnType>;
    brokerGetBrokerNdDepositDetail (params?: {}): Promise<implicitReturnType>;
    brokerGetBrokerNdWithdrawDetail (params?: {}): Promise<implicitReturnType>;
    brokerPostBrokerNdTransfer (params?: {}): Promise<implicitReturnType>;
    brokerPostBrokerNdAccount (params?: {}): Promise<implicitReturnType>;
    brokerPostBrokerNdAccountApikey (params?: {}): Promise<implicitReturnType>;
    brokerPostBrokerNdAccountUpdateApikey (params?: {}): Promise<implicitReturnType>;
    brokerDeleteBrokerNdAccountApikey (params?: {}): Promise<implicitReturnType>;
    earnGetOtcLoanLoan (params?: {}): Promise<implicitReturnType>;
    earnGetOtcLoanAccounts (params?: {}): Promise<implicitReturnType>;
    earnGetEarnRedeemPreview (params?: {}): Promise<implicitReturnType>;
    earnGetEarnSavingProducts (params?: {}): Promise<implicitReturnType>;
    earnGetEarnHoldAssets (params?: {}): Promise<implicitReturnType>;
    earnGetEarnPromotionProducts (params?: {}): Promise<implicitReturnType>;
    earnGetEarnKcsStakingProducts (params?: {}): Promise<implicitReturnType>;
    earnGetEarnStakingProducts (params?: {}): Promise<implicitReturnType>;
    earnGetEarnEthStakingProducts (params?: {}): Promise<implicitReturnType>;
    earnPostEarnOrders (params?: {}): Promise<implicitReturnType>;
    earnDeleteEarnOrders (params?: {}): Promise<implicitReturnType>;
}
abstract class kucoin extends _kucoin {}

export default kucoin
