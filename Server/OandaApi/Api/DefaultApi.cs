using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi
    {
        /// <summary>
        /// Cancel Order Cancel a pending Order in an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="orderSpecifier">The Order Specifier</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="clientRequestID">Client specified RequestID to be sent with request.</param>
        /// <returns>InlineResponse20032</returns>
        InlineResponse20032 CancelOrder (string accountID, string orderSpecifier, string acceptDatetimeFormat, string clientRequestID);
        /// <summary>
        /// Close Position Closeout the open Position for a specific instrument in an Account.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="instrument">Name of the Instrument</param>
        /// <param name="closePositionBody">Representation of how to close the position</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 ClosePosition (string accountID, string instrument, ClosePositionBody closePositionBody, string acceptDatetimeFormat);
        /// <summary>
        /// Close Trade Close (partially or fully) a specific open Trade in an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="tradeSpecifier">Specifier for the Trade</param>
        /// <param name="closeTradeBody">Details of how much of the open Trade to close.</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 CloseTrade (string accountID, string tradeSpecifier, CloseTradeBody closeTradeBody, string acceptDatetimeFormat);
        /// <summary>
        /// Configure Account Set the client-configurable portions of an Account.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="configureAccountBody">Representation of the Account configuration to set</param>
        /// <returns>InlineResponse20019</returns>
        InlineResponse20019 ConfigureAccount (string accountID, string acceptDatetimeFormat, ConfigureAccountBody configureAccountBody);
        /// <summary>
        /// Create Order Create an Order for an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="createOrderBody"></param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <returns>InlineResponse201</returns>
        InlineResponse201 CreateOrder (string accountID, CreateOrderBody createOrderBody, string acceptDatetimeFormat);
        /// <summary>
        /// Account Details Get the full details for a single Account that a client has access to. Full pending Order, open Trade and open Position representations are provided.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <returns>InlineResponse20016</returns>
        InlineResponse20016 GetAccount (string accountID, string acceptDatetimeFormat);
        /// <summary>
        /// Poll Account Updates Endpoint used to poll an Account for its current state and changes since a specified TransactionID.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="sinceTransactionID">ID of the Transaction to get Account changes since.</param>
        /// <returns>InlineResponse20020</returns>
        InlineResponse20020 GetAccountChanges (string accountID, string acceptDatetimeFormat, string sinceTransactionID);
        /// <summary>
        /// Account Instruments Get the list of tradeable instruments for the given Account. The list of tradeable instruments is dependent on the regulatory division that the Account is located in, thus should be the same for all Accounts owned by a single user.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="instruments">List of instruments to query specifically.</param>
        /// <returns>InlineResponse20018</returns>
        InlineResponse20018 GetAccountInstruments (string accountID, List<string> instruments);
        /// <summary>
        /// Account Summary Get a summary for a single Account that a client has access to.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 GetAccountSummary (string accountID, string acceptDatetimeFormat);
        /// <summary>
        /// Get Base Prices Get pricing information for a specified instrument. Accounts are not associated in any way with this endpoint.
        /// </summary>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="time">The time at which the desired price for each instrument is in effect. The current price for each instrument is returned if no time is provided.</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 GetBasePrices (string acceptDatetimeFormat, string time);
        /// <summary>
        /// External User Info Fetch the externally-available user information for the specified user. This endpoint is intended to be used by 3rd parties that have been authorized by a user to view their personal information.
        /// </summary>
        /// <param name="userSpecifier">The User Specifier</param>
        /// <returns>InlineResponse20026</returns>
        InlineResponse20026 GetExternalUserInfo (string userSpecifier);
        /// <summary>
        /// Get Candlesticks Fetch candlestick data for an instrument.
        /// </summary>
        /// <param name="instrument">Name of the Instrument</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="price">The Price component(s) to get candlestick data for. Can contain any combination of the characters \&quot;M\&quot; (midpoint candles) \&quot;B\&quot; (bid candles) and \&quot;A\&quot; (ask candles).</param>
        /// <param name="granularity">The granularity of the candlesticks to fetch</param>
        /// <param name="count">The number of candlesticks to return in the reponse. Count should not be specified if both the start and end parameters are provided, as the time range combined with the graularity will determine the number of candlesticks to return.</param>
        /// <param name="from">The start of the time range to fetch candlesticks for.</param>
        /// <param name="to">The end of the time range to fetch candlesticks for.</param>
        /// <param name="smooth">A flag that controls whether the candlestick is \&quot;smoothed\&quot; or not.  A smoothed candlestick uses the previous candle&#39;s close price as its open price, while an unsmoothed candlestick uses the first price from its time range as its open price.</param>
        /// <param name="includeFirst">A flag that controls whether the candlestick that is covered by the from time should be included in the results. This flag enables clients to use the timestamp of the last completed candlestick received to poll for future candlesticks but avoid receiving the previous candlestick repeatedly.</param>
        /// <param name="dailyAlignment">The hour of the day (in the specified timezone) to use for granularities that have daily alignments.</param>
        /// <param name="alignmentTimezone">The timezone to use for the dailyAlignment parameter. Candlesticks with daily alignment will be aligned to the dailyAlignment hour within the alignmentTimezone.  Note that the returned times will still be represented in UTC.</param>
        /// <param name="weeklyAlignment">The day of the week used for granularities that have weekly alignment.</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetInstrumentCandles (string instrument, string acceptDatetimeFormat, string price, string granularity, int? count, string from, string to, bool? smooth, bool? includeFirst, int? dailyAlignment, string alignmentTimezone, string weeklyAlignment);
        /// <summary>
        /// Get Candlesticks Fetch candlestick data for an instrument.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="instrument">Name of the Instrument</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="price">The Price component(s) to get candlestick data for. Can contain any combination of the characters \&quot;M\&quot; (midpoint candles) \&quot;B\&quot; (bid candles) and \&quot;A\&quot; (ask candles).</param>
        /// <param name="granularity">The granularity of the candlesticks to fetch</param>
        /// <param name="count">The number of candlesticks to return in the response. Count should not be specified if both the start and end parameters are provided, as the time range combined with the granularity will determine the number of candlesticks to return.</param>
        /// <param name="from">The start of the time range to fetch candlesticks for.</param>
        /// <param name="to">The end of the time range to fetch candlesticks for.</param>
        /// <param name="smooth">A flag that controls whether the candlestick is \&quot;smoothed\&quot; or not.  A smoothed candlestick uses the previous candle&#39;s close price as its open price, while an unsmoothed candlestick uses the first price from its time range as its open price.</param>
        /// <param name="includeFirst">A flag that controls whether the candlestick that is covered by the from time should be included in the results. This flag enables clients to use the timestamp of the last completed candlestick received to poll for future candlesticks but avoid receiving the previous candlestick repeatedly.</param>
        /// <param name="dailyAlignment">The hour of the day (in the specified timezone) to use for granularities that have daily alignments.</param>
        /// <param name="alignmentTimezone">The timezone to use for the dailyAlignment parameter. Candlesticks with daily alignment will be aligned to the dailyAlignment hour within the alignmentTimezone.  Note that the returned times will still be represented in UTC.</param>
        /// <param name="weeklyAlignment">The day of the week used for granularities that have weekly alignment.</param>
        /// <param name="units">The number of units used to calculate the volume-weighted average bid and ask prices in the returned candles.</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetInstrumentCandles2 (string accountID, string instrument, string acceptDatetimeFormat, string price, string granularity, int? count, string from, string to, bool? smooth, bool? includeFirst, int? dailyAlignment, string alignmentTimezone, string weeklyAlignment, string units);
        /// <summary>
        /// Price Fetch a price for an instrument. Accounts are not associated in any way with this endpoint.
        /// </summary>
        /// <param name="instrument">Name of the Instrument</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="time">The time at which the desired price is in effect. The current price is returned if no time is provided.</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetInstrumentPrice (string instrument, string acceptDatetimeFormat, string time);
        /// <summary>
        /// Get Prices Fetch a range of prices for an instrument. Accounts are not associated in any way with this endpoint.
        /// </summary>
        /// <param name="instrument">Name of the Instrument</param>
        /// <param name="from">The start of the time range to fetch prices for.</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="to">The end of the time range to fetch prices for. The current time is used if this parameter is not provided.</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 GetInstrumentPriceRange (string instrument, string from, string acceptDatetimeFormat, string to);
        /// <summary>
        /// Get Order Get details for a single Order in an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="orderSpecifier">The Order Specifier</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <returns>InlineResponse20031</returns>
        InlineResponse20031 GetOrder (string accountID, string orderSpecifier, string acceptDatetimeFormat);
        /// <summary>
        /// Instrument Position Get the details of a single Instrument&#39;s Position in an Account. The Position may by open or not.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="instrument">Name of the Instrument</param>
        /// <returns>InlineResponse2007</returns>
        InlineResponse2007 GetPosition (string accountID, string instrument);
        /// <summary>
        /// Get Price Range Get pricing information for a specified range of prices. Accounts are not associated in any way with this endpoint.
        /// </summary>
        /// <param name="instrument">Name of the Instrument</param>
        /// <param name="from">The start of the time range to fetch prices for.</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="to">The end of the time range to fetch prices for. The current time is used if this parameter is not provided.</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 GetPriceRange (string instrument, string from, string acceptDatetimeFormat, string to);
        /// <summary>
        /// Current Account Prices Get pricing information for a specified list of Instruments within an Account.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="instruments">List of Instruments to get pricing for.</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="since">Date/Time filter to apply to the response. Only prices and home conversions (if requested) with a time later than this filter (i.e. the price has changed after the since time) will be provided, and are filtered independently.</param>
        /// <param name="includeUnitsAvailable">Flag that enables the inclusion of the unitsAvailable field in the returned Price objects.</param>
        /// <param name="includeHomeConversions">Flag that enables the inclusion of the homeConversions field in the returned response. An entry will be returned for each currency in the set of all base and quote currencies present in the requested instruments list.</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 GetPrices (string accountID, List<string> instruments, string acceptDatetimeFormat, string since, bool? includeUnitsAvailable, bool? includeHomeConversions);
        /// <summary>
        /// Trade Details Get the details of a specific Trade in an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="tradeSpecifier">Specifier for the Trade</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 GetTrade (string accountID, string tradeSpecifier, string acceptDatetimeFormat);
        /// <summary>
        /// Transaction Details Get the details of a single Account Transaction.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="transactionID">A Transaction ID</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 GetTransaction (string accountID, string transactionID, string acceptDatetimeFormat);
        /// <summary>
        /// Transaction ID Range Get a range of Transactions for an Account based on the Transaction IDs.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="from">The starting Transacion ID (inclusive) to fetch.</param>
        /// <param name="to">The ending Transaction ID (inclusive) to fetch.</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="type">The filter that restricts the types of Transactions to retreive.</param>
        /// <returns>InlineResponse20023</returns>
        InlineResponse20023 GetTransactionRange (string accountID, string from, string to, string acceptDatetimeFormat, List<string> type);
        /// <summary>
        /// Transactions Since ID Get a range of Transactions for an Account starting at (but not including) a provided Transaction ID.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="id">The ID of the last Transacion fetched. This query will return all Transactions newer than the TransactionID.</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <returns>InlineResponse20023</returns>
        InlineResponse20023 GetTransactionsSinceId (string accountID, string id, string acceptDatetimeFormat);
        /// <summary>
        /// User Info Fetch the user information for the specified user. This endpoint is intended to be used by the user themself to obtain their own information.
        /// </summary>
        /// <param name="userSpecifier">The User Specifier</param>
        /// <returns>InlineResponse20025</returns>
        InlineResponse20025 GetUserInfo (string userSpecifier);
        /// <summary>
        /// Get Order Book Fetch an order book for an instrument.
        /// </summary>
        /// <param name="instrument">Name of the Instrument</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="time">The time of the snapshot to fetch. If not specified, then the most recent snapshot is fetched.</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 InstrumentsInstrumentOrderBookGet (string instrument, string acceptDatetimeFormat, string time);
        /// <summary>
        /// Get Position Book Fetch a position book for an instrument.
        /// </summary>
        /// <param name="instrument">Name of the Instrument</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="time">The time of the snapshot to fetch. If not specified, then the most recent snapshot is fetched.</param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 InstrumentsInstrumentPositionBookGet (string instrument, string acceptDatetimeFormat, string time);
        /// <summary>
        /// List Accounts Get a list of all Accounts authorized for the provided token.
        /// </summary>
        /// <returns>InlineResponse20015</returns>
        InlineResponse20015 ListAccounts ();
        /// <summary>
        /// Open Positions List all open Positions for an Account. An open Position is a Position in an Account that currently has a Trade opened for it.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 ListOpenPositions (string accountID);
        /// <summary>
        /// List Open Trades Get the list of open Trades for an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 ListOpenTrades (string accountID, string acceptDatetimeFormat);
        /// <summary>
        /// List Orders Get a list of Orders for an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="ids">List of Order IDs to retrieve</param>
        /// <param name="state">The state to filter the requested Orders by</param>
        /// <param name="instrument">The instrument to filter the requested orders by</param>
        /// <param name="count">The maximum number of Orders to return</param>
        /// <param name="beforeID">The maximum Order ID to return. If not provided the most recent Orders in the Account are returned</param>
        /// <returns>InlineResponse20029</returns>
        InlineResponse20029 ListOrders (string accountID, string acceptDatetimeFormat, List<string> ids, string state, string instrument, int? count, string beforeID);
        /// <summary>
        /// Pending Orders List all pending Orders in an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <returns>InlineResponse20030</returns>
        InlineResponse20030 ListPendingOrders (string accountID, string acceptDatetimeFormat);
        /// <summary>
        /// List Positions List all Positions for an Account. The Positions returned are for every instrument that has had a position during the lifetime of an the Account.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 ListPositions (string accountID);
        /// <summary>
        /// List Trades Get a list of Trades for an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="ids">List of Trade IDs to retrieve.</param>
        /// <param name="state">The state to filter the requested Trades by.</param>
        /// <param name="instrument">The instrument to filter the requested Trades by.</param>
        /// <param name="count">The maximum number of Trades to return.</param>
        /// <param name="beforeID">The maximum Trade ID to return. If not provided the most recent Trades in the Account are returned.</param>
        /// <returns>InlineResponse2009</returns>
        InlineResponse2009 ListTrades (string accountID, string acceptDatetimeFormat, List<string> ids, string state, string instrument, int? count, string beforeID);
        /// <summary>
        /// List Transactions Get a list of Transactions pages that satisfy a time-based Transaction query.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="from">The starting time (inclusive) of the time range for the Transactions being queried.</param>
        /// <param name="to">The ending time (inclusive) of the time range for the Transactions being queried.</param>
        /// <param name="pageSize">The number of Transactions to include in each page of the results.</param>
        /// <param name="type">A filter for restricting the types of Transactions to retreive.</param>
        /// <returns>InlineResponse20021</returns>
        InlineResponse20021 ListTransactions (string accountID, string acceptDatetimeFormat, string from, string to, int? pageSize, List<string> type);
        /// <summary>
        /// Replace Order Replace an Order in an Account by simultaneously cancelling it and creating a replacement Order
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="orderSpecifier">The Order Specifier</param>
        /// <param name="replaceOrderBody">Specification of the replacing Order. The replacing order must have the same type as the replaced Order.</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="clientRequestID">Client specified RequestID to be sent with request.</param>
        /// <returns>InlineResponse2011</returns>
        InlineResponse2011 ReplaceOrder (string accountID, string orderSpecifier, ReplaceOrderBody replaceOrderBody, string acceptDatetimeFormat, string clientRequestID);
        /// <summary>
        /// Set Order Extensions Update the Client Extensions for an Order in an Account. Do not set, modify, or delete clientExtensions if your account is associated with MT4.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="orderSpecifier">The Order Specifier</param>
        /// <param name="setOrderClientExtensionsBody">Representation of the replacing Order</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <returns>InlineResponse20033</returns>
        InlineResponse20033 SetOrderClientExtensions (string accountID, string orderSpecifier, SetOrderClientExtensionsBody setOrderClientExtensionsBody, string acceptDatetimeFormat);
        /// <summary>
        /// Set Trade Client Extensions Update the Client Extensions for a Trade. Do not add, update, or delete the Client Extensions if your account is associated with MT4.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="tradeSpecifier">Specifier for the Trade</param>
        /// <param name="setTradeClientExtensionsBody">Details of how to modify the Trade&#39;s Client Extensions.</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 SetTradeClientExtensions (string accountID, string tradeSpecifier, SetTradeClientExtensionsBody setTradeClientExtensionsBody, string acceptDatetimeFormat);
        /// <summary>
        /// Set Dependent Orders Create, replace and cancel a Trade&#39;s dependent Orders (Take Profit, Stop Loss and Trailing Stop Loss) through the Trade itself
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="tradeSpecifier">Specifier for the Trade</param>
        /// <param name="setTradeDependentOrdersBody">Details of how to modify the Trade&#39;s dependent Orders.</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <returns>InlineResponse20014</returns>
        InlineResponse20014 SetTradeDependentOrders (string accountID, string tradeSpecifier, SetTradeDependentOrdersBody setTradeDependentOrdersBody, string acceptDatetimeFormat);
        /// <summary>
        /// Price Stream Get a stream of Account Prices starting from when the request is made. This pricing stream does not include every single price created for the Account, but instead will provide at most 4 prices per second (every 250 milliseconds) for each instrument being requested. If more than one price is created for an instrument during the 250 millisecond window, only the price in effect at the end of the window is sent. This means that during periods of rapid price movement, subscribers to this stream will not be sent every price. Pricing windows for different connections to the price stream are not all aligned in the same way (i.e. they are not all aligned to the top of the second). This means that during periods of rapid price movement, different subscribers may observe different prices depending on their alignment.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <param name="instruments">List of Instruments to stream Prices for.</param>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param>
        /// <param name="snapshot">Flag that enables/disables the sending of a pricing snapshot when initially connecting to the stream.</param>
        /// <returns>InlineResponse20028</returns>
        InlineResponse20028 StreamPricing (string accountID, List<string> instruments, string acceptDatetimeFormat, bool? snapshot);
        /// <summary>
        /// Transaction Stream Get a stream of Transactions for an Account starting from when the request is made.
        /// </summary>
        /// <param name="accountID">Account Identifier</param>
        /// <returns>InlineResponse20024</returns>
        InlineResponse20024 StreamTransactions (string accountID);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DefaultApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Cancel Order Cancel a pending Order in an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="orderSpecifier">The Order Specifier</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="clientRequestID">Client specified RequestID to be sent with request.</param> 
        /// <returns>InlineResponse20032</returns>            
        public InlineResponse20032 CancelOrder (string accountID, string orderSpecifier, string acceptDatetimeFormat, string clientRequestID)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling CancelOrder");
            
            // verify the required parameter 'orderSpecifier' is set
            if (orderSpecifier == null) throw new ApiException(400, "Missing required parameter 'orderSpecifier' when calling CancelOrder");
            
    
            var path = "/accounts/{accountID}/orders/{orderSpecifier}/cancel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
path = path.Replace("{" + "orderSpecifier" + "}", ApiClient.ParameterToString(orderSpecifier));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
 if (clientRequestID != null) headerParams.Add("ClientRequestID", ApiClient.ParameterToString(clientRequestID)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CancelOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CancelOrder: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20032) ApiClient.Deserialize(response.Content, typeof(InlineResponse20032), response.Headers);
        }
    
        /// <summary>
        /// Close Position Closeout the open Position for a specific instrument in an Account.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="instrument">Name of the Instrument</param> 
        /// <param name="closePositionBody">Representation of how to close the position</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <returns>InlineResponse2008</returns>            
        public InlineResponse2008 ClosePosition (string accountID, string instrument, ClosePositionBody closePositionBody, string acceptDatetimeFormat)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling ClosePosition");
            
            // verify the required parameter 'instrument' is set
            if (instrument == null) throw new ApiException(400, "Missing required parameter 'instrument' when calling ClosePosition");
            
            // verify the required parameter 'closePositionBody' is set
            if (closePositionBody == null) throw new ApiException(400, "Missing required parameter 'closePositionBody' when calling ClosePosition");
            
    
            var path = "/accounts/{accountID}/positions/{instrument}/close";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
path = path.Replace("{" + "instrument" + "}", ApiClient.ParameterToString(instrument));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                        postBody = ApiClient.Serialize(closePositionBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ClosePosition: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClosePosition: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2008) ApiClient.Deserialize(response.Content, typeof(InlineResponse2008), response.Headers);
        }
    
        /// <summary>
        /// Close Trade Close (partially or fully) a specific open Trade in an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="tradeSpecifier">Specifier for the Trade</param> 
        /// <param name="closeTradeBody">Details of how much of the open Trade to close.</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <returns>InlineResponse20012</returns>            
        public InlineResponse20012 CloseTrade (string accountID, string tradeSpecifier, CloseTradeBody closeTradeBody, string acceptDatetimeFormat)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling CloseTrade");
            
            // verify the required parameter 'tradeSpecifier' is set
            if (tradeSpecifier == null) throw new ApiException(400, "Missing required parameter 'tradeSpecifier' when calling CloseTrade");
            
            // verify the required parameter 'closeTradeBody' is set
            if (closeTradeBody == null) throw new ApiException(400, "Missing required parameter 'closeTradeBody' when calling CloseTrade");
            
    
            var path = "/accounts/{accountID}/trades/{tradeSpecifier}/close";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
path = path.Replace("{" + "tradeSpecifier" + "}", ApiClient.ParameterToString(tradeSpecifier));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                        postBody = ApiClient.Serialize(closeTradeBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CloseTrade: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CloseTrade: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20012) ApiClient.Deserialize(response.Content, typeof(InlineResponse20012), response.Headers);
        }
    
        /// <summary>
        /// Configure Account Set the client-configurable portions of an Account.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="configureAccountBody">Representation of the Account configuration to set</param> 
        /// <returns>InlineResponse20019</returns>            
        public InlineResponse20019 ConfigureAccount (string accountID, string acceptDatetimeFormat, ConfigureAccountBody configureAccountBody)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling ConfigureAccount");
            
    
            var path = "/accounts/{accountID}/configuration";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                        postBody = ApiClient.Serialize(configureAccountBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ConfigureAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ConfigureAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20019) ApiClient.Deserialize(response.Content, typeof(InlineResponse20019), response.Headers);
        }
    
        /// <summary>
        /// Create Order Create an Order for an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="createOrderBody"></param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <returns>InlineResponse201</returns>            
        public InlineResponse201 CreateOrder (string accountID, CreateOrderBody createOrderBody, string acceptDatetimeFormat)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling CreateOrder");
            
            // verify the required parameter 'createOrderBody' is set
            if (createOrderBody == null) throw new ApiException(400, "Missing required parameter 'createOrderBody' when calling CreateOrder");
            
    
            var path = "/accounts/{accountID}/orders";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                        postBody = ApiClient.Serialize(createOrderBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateOrder: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse201) ApiClient.Deserialize(response.Content, typeof(InlineResponse201), response.Headers);
        }
    
        /// <summary>
        /// Account Details Get the full details for a single Account that a client has access to. Full pending Order, open Trade and open Position representations are provided.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <returns>InlineResponse20016</returns>            
        public InlineResponse20016 GetAccount (string accountID, string acceptDatetimeFormat)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling GetAccount");
            
    
            var path = "/accounts/{accountID}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20016) ApiClient.Deserialize(response.Content, typeof(InlineResponse20016), response.Headers);
        }
    
        /// <summary>
        /// Poll Account Updates Endpoint used to poll an Account for its current state and changes since a specified TransactionID.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="sinceTransactionID">ID of the Transaction to get Account changes since.</param> 
        /// <returns>InlineResponse20020</returns>            
        public InlineResponse20020 GetAccountChanges (string accountID, string acceptDatetimeFormat, string sinceTransactionID)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling GetAccountChanges");
            
    
            var path = "/accounts/{accountID}/changes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (sinceTransactionID != null) queryParams.Add("sinceTransactionID", ApiClient.ParameterToString(sinceTransactionID)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountChanges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountChanges: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20020) ApiClient.Deserialize(response.Content, typeof(InlineResponse20020), response.Headers);
        }
    
        /// <summary>
        /// Account Instruments Get the list of tradeable instruments for the given Account. The list of tradeable instruments is dependent on the regulatory division that the Account is located in, thus should be the same for all Accounts owned by a single user.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="instruments">List of instruments to query specifically.</param> 
        /// <returns>InlineResponse20018</returns>            
        public InlineResponse20018 GetAccountInstruments (string accountID, List<string> instruments)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling GetAccountInstruments");
            
    
            var path = "/accounts/{accountID}/instruments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (instruments != null) queryParams.Add("instruments", ApiClient.ParameterToString(instruments)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountInstruments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountInstruments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20018) ApiClient.Deserialize(response.Content, typeof(InlineResponse20018), response.Headers);
        }
    
        /// <summary>
        /// Account Summary Get a summary for a single Account that a client has access to.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <returns>InlineResponse20017</returns>            
        public InlineResponse20017 GetAccountSummary (string accountID, string acceptDatetimeFormat)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling GetAccountSummary");
            
    
            var path = "/accounts/{accountID}/summary";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountSummary: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountSummary: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20017) ApiClient.Deserialize(response.Content, typeof(InlineResponse20017), response.Headers);
        }
    
        /// <summary>
        /// Get Base Prices Get pricing information for a specified instrument. Accounts are not associated in any way with this endpoint.
        /// </summary>
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="time">The time at which the desired price for each instrument is in effect. The current price for each instrument is returned if no time is provided.</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 GetBasePrices (string acceptDatetimeFormat, string time)
        {
            
    
            var path = "/pricing";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (time != null) queryParams.Add("time", ApiClient.ParameterToString(time)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBasePrices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBasePrices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        /// <summary>
        /// External User Info Fetch the externally-available user information for the specified user. This endpoint is intended to be used by 3rd parties that have been authorized by a user to view their personal information.
        /// </summary>
        /// <param name="userSpecifier">The User Specifier</param> 
        /// <returns>InlineResponse20026</returns>            
        public InlineResponse20026 GetExternalUserInfo (string userSpecifier)
        {
            
            // verify the required parameter 'userSpecifier' is set
            if (userSpecifier == null) throw new ApiException(400, "Missing required parameter 'userSpecifier' when calling GetExternalUserInfo");
            
    
            var path = "/users/{userSpecifier}/externalInfo";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userSpecifier" + "}", ApiClient.ParameterToString(userSpecifier));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExternalUserInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExternalUserInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20026) ApiClient.Deserialize(response.Content, typeof(InlineResponse20026), response.Headers);
        }
    
        /// <summary>
        /// Get Candlesticks Fetch candlestick data for an instrument.
        /// </summary>
        /// <param name="instrument">Name of the Instrument</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="price">The Price component(s) to get candlestick data for. Can contain any combination of the characters \&quot;M\&quot; (midpoint candles) \&quot;B\&quot; (bid candles) and \&quot;A\&quot; (ask candles).</param> 
        /// <param name="granularity">The granularity of the candlesticks to fetch</param> 
        /// <param name="count">The number of candlesticks to return in the reponse. Count should not be specified if both the start and end parameters are provided, as the time range combined with the graularity will determine the number of candlesticks to return.</param> 
        /// <param name="from">The start of the time range to fetch candlesticks for.</param> 
        /// <param name="to">The end of the time range to fetch candlesticks for.</param> 
        /// <param name="smooth">A flag that controls whether the candlestick is \&quot;smoothed\&quot; or not.  A smoothed candlestick uses the previous candle&#39;s close price as its open price, while an unsmoothed candlestick uses the first price from its time range as its open price.</param> 
        /// <param name="includeFirst">A flag that controls whether the candlestick that is covered by the from time should be included in the results. This flag enables clients to use the timestamp of the last completed candlestick received to poll for future candlesticks but avoid receiving the previous candlestick repeatedly.</param> 
        /// <param name="dailyAlignment">The hour of the day (in the specified timezone) to use for granularities that have daily alignments.</param> 
        /// <param name="alignmentTimezone">The timezone to use for the dailyAlignment parameter. Candlesticks with daily alignment will be aligned to the dailyAlignment hour within the alignmentTimezone.  Note that the returned times will still be represented in UTC.</param> 
        /// <param name="weeklyAlignment">The day of the week used for granularities that have weekly alignment.</param> 
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 GetInstrumentCandles (string instrument, string acceptDatetimeFormat, string price, string granularity, int? count, string from, string to, bool? smooth, bool? includeFirst, int? dailyAlignment, string alignmentTimezone, string weeklyAlignment)
        {
            
            // verify the required parameter 'instrument' is set
            if (instrument == null) throw new ApiException(400, "Missing required parameter 'instrument' when calling GetInstrumentCandles");
            
    
            var path = "/instruments/{instrument}/candles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "instrument" + "}", ApiClient.ParameterToString(instrument));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (price != null) queryParams.Add("price", ApiClient.ParameterToString(price)); // query parameter
 if (granularity != null) queryParams.Add("granularity", ApiClient.ParameterToString(granularity)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
 if (smooth != null) queryParams.Add("smooth", ApiClient.ParameterToString(smooth)); // query parameter
 if (includeFirst != null) queryParams.Add("includeFirst", ApiClient.ParameterToString(includeFirst)); // query parameter
 if (dailyAlignment != null) queryParams.Add("dailyAlignment", ApiClient.ParameterToString(dailyAlignment)); // query parameter
 if (alignmentTimezone != null) queryParams.Add("alignmentTimezone", ApiClient.ParameterToString(alignmentTimezone)); // query parameter
 if (weeklyAlignment != null) queryParams.Add("weeklyAlignment", ApiClient.ParameterToString(weeklyAlignment)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstrumentCandles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstrumentCandles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
        /// <summary>
        /// Get Candlesticks Fetch candlestick data for an instrument.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="instrument">Name of the Instrument</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="price">The Price component(s) to get candlestick data for. Can contain any combination of the characters \&quot;M\&quot; (midpoint candles) \&quot;B\&quot; (bid candles) and \&quot;A\&quot; (ask candles).</param> 
        /// <param name="granularity">The granularity of the candlesticks to fetch</param> 
        /// <param name="count">The number of candlesticks to return in the response. Count should not be specified if both the start and end parameters are provided, as the time range combined with the granularity will determine the number of candlesticks to return.</param> 
        /// <param name="from">The start of the time range to fetch candlesticks for.</param> 
        /// <param name="to">The end of the time range to fetch candlesticks for.</param> 
        /// <param name="smooth">A flag that controls whether the candlestick is \&quot;smoothed\&quot; or not.  A smoothed candlestick uses the previous candle&#39;s close price as its open price, while an unsmoothed candlestick uses the first price from its time range as its open price.</param> 
        /// <param name="includeFirst">A flag that controls whether the candlestick that is covered by the from time should be included in the results. This flag enables clients to use the timestamp of the last completed candlestick received to poll for future candlesticks but avoid receiving the previous candlestick repeatedly.</param> 
        /// <param name="dailyAlignment">The hour of the day (in the specified timezone) to use for granularities that have daily alignments.</param> 
        /// <param name="alignmentTimezone">The timezone to use for the dailyAlignment parameter. Candlesticks with daily alignment will be aligned to the dailyAlignment hour within the alignmentTimezone.  Note that the returned times will still be represented in UTC.</param> 
        /// <param name="weeklyAlignment">The day of the week used for granularities that have weekly alignment.</param> 
        /// <param name="units">The number of units used to calculate the volume-weighted average bid and ask prices in the returned candles.</param> 
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 GetInstrumentCandles2 (string accountID, string instrument, string acceptDatetimeFormat, string price, string granularity, int? count, string from, string to, bool? smooth, bool? includeFirst, int? dailyAlignment, string alignmentTimezone, string weeklyAlignment, string units)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling GetInstrumentCandles2");
            
            // verify the required parameter 'instrument' is set
            if (instrument == null) throw new ApiException(400, "Missing required parameter 'instrument' when calling GetInstrumentCandles2");
            
    
            var path = "/accounts/{accountID}/instruments/{instrument}/candles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
path = path.Replace("{" + "instrument" + "}", ApiClient.ParameterToString(instrument));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (price != null) queryParams.Add("price", ApiClient.ParameterToString(price)); // query parameter
 if (granularity != null) queryParams.Add("granularity", ApiClient.ParameterToString(granularity)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
 if (smooth != null) queryParams.Add("smooth", ApiClient.ParameterToString(smooth)); // query parameter
 if (includeFirst != null) queryParams.Add("includeFirst", ApiClient.ParameterToString(includeFirst)); // query parameter
 if (dailyAlignment != null) queryParams.Add("dailyAlignment", ApiClient.ParameterToString(dailyAlignment)); // query parameter
 if (alignmentTimezone != null) queryParams.Add("alignmentTimezone", ApiClient.ParameterToString(alignmentTimezone)); // query parameter
 if (weeklyAlignment != null) queryParams.Add("weeklyAlignment", ApiClient.ParameterToString(weeklyAlignment)); // query parameter
 if (units != null) queryParams.Add("units", ApiClient.ParameterToString(units)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstrumentCandles2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstrumentCandles2: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
        /// <summary>
        /// Price Fetch a price for an instrument. Accounts are not associated in any way with this endpoint.
        /// </summary>
        /// <param name="instrument">Name of the Instrument</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="time">The time at which the desired price is in effect. The current price is returned if no time is provided.</param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 GetInstrumentPrice (string instrument, string acceptDatetimeFormat, string time)
        {
            
            // verify the required parameter 'instrument' is set
            if (instrument == null) throw new ApiException(400, "Missing required parameter 'instrument' when calling GetInstrumentPrice");
            
    
            var path = "/instruments/{instrument}/price";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "instrument" + "}", ApiClient.ParameterToString(instrument));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (time != null) queryParams.Add("time", ApiClient.ParameterToString(time)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstrumentPrice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstrumentPrice: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        /// <summary>
        /// Get Prices Fetch a range of prices for an instrument. Accounts are not associated in any way with this endpoint.
        /// </summary>
        /// <param name="instrument">Name of the Instrument</param> 
        /// <param name="from">The start of the time range to fetch prices for.</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="to">The end of the time range to fetch prices for. The current time is used if this parameter is not provided.</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 GetInstrumentPriceRange (string instrument, string from, string acceptDatetimeFormat, string to)
        {
            
            // verify the required parameter 'instrument' is set
            if (instrument == null) throw new ApiException(400, "Missing required parameter 'instrument' when calling GetInstrumentPriceRange");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling GetInstrumentPriceRange");
            
    
            var path = "/instruments/{instrument}/price/range";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "instrument" + "}", ApiClient.ParameterToString(instrument));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstrumentPriceRange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstrumentPriceRange: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        /// <summary>
        /// Get Order Get details for a single Order in an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="orderSpecifier">The Order Specifier</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <returns>InlineResponse20031</returns>            
        public InlineResponse20031 GetOrder (string accountID, string orderSpecifier, string acceptDatetimeFormat)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling GetOrder");
            
            // verify the required parameter 'orderSpecifier' is set
            if (orderSpecifier == null) throw new ApiException(400, "Missing required parameter 'orderSpecifier' when calling GetOrder");
            
    
            var path = "/accounts/{accountID}/orders/{orderSpecifier}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
path = path.Replace("{" + "orderSpecifier" + "}", ApiClient.ParameterToString(orderSpecifier));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrder: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20031) ApiClient.Deserialize(response.Content, typeof(InlineResponse20031), response.Headers);
        }
    
        /// <summary>
        /// Instrument Position Get the details of a single Instrument&#39;s Position in an Account. The Position may by open or not.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="instrument">Name of the Instrument</param> 
        /// <returns>InlineResponse2007</returns>            
        public InlineResponse2007 GetPosition (string accountID, string instrument)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling GetPosition");
            
            // verify the required parameter 'instrument' is set
            if (instrument == null) throw new ApiException(400, "Missing required parameter 'instrument' when calling GetPosition");
            
    
            var path = "/accounts/{accountID}/positions/{instrument}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
path = path.Replace("{" + "instrument" + "}", ApiClient.ParameterToString(instrument));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPosition: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPosition: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2007) ApiClient.Deserialize(response.Content, typeof(InlineResponse2007), response.Headers);
        }
    
        /// <summary>
        /// Get Price Range Get pricing information for a specified range of prices. Accounts are not associated in any way with this endpoint.
        /// </summary>
        /// <param name="instrument">Name of the Instrument</param> 
        /// <param name="from">The start of the time range to fetch prices for.</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="to">The end of the time range to fetch prices for. The current time is used if this parameter is not provided.</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 GetPriceRange (string instrument, string from, string acceptDatetimeFormat, string to)
        {
            
            // verify the required parameter 'instrument' is set
            if (instrument == null) throw new ApiException(400, "Missing required parameter 'instrument' when calling GetPriceRange");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling GetPriceRange");
            
    
            var path = "/pricing/range";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "instrument" + "}", ApiClient.ParameterToString(instrument));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPriceRange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPriceRange: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        /// <summary>
        /// Current Account Prices Get pricing information for a specified list of Instruments within an Account.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="instruments">List of Instruments to get pricing for.</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="since">Date/Time filter to apply to the response. Only prices and home conversions (if requested) with a time later than this filter (i.e. the price has changed after the since time) will be provided, and are filtered independently.</param> 
        /// <param name="includeUnitsAvailable">Flag that enables the inclusion of the unitsAvailable field in the returned Price objects.</param> 
        /// <param name="includeHomeConversions">Flag that enables the inclusion of the homeConversions field in the returned response. An entry will be returned for each currency in the set of all base and quote currencies present in the requested instruments list.</param> 
        /// <returns>InlineResponse20027</returns>            
        public InlineResponse20027 GetPrices (string accountID, List<string> instruments, string acceptDatetimeFormat, string since, bool? includeUnitsAvailable, bool? includeHomeConversions)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling GetPrices");
            
            // verify the required parameter 'instruments' is set
            if (instruments == null) throw new ApiException(400, "Missing required parameter 'instruments' when calling GetPrices");
            
    
            var path = "/accounts/{accountID}/pricing";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (instruments != null) queryParams.Add("instruments", ApiClient.ParameterToString(instruments)); // query parameter
 if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (includeUnitsAvailable != null) queryParams.Add("includeUnitsAvailable", ApiClient.ParameterToString(includeUnitsAvailable)); // query parameter
 if (includeHomeConversions != null) queryParams.Add("includeHomeConversions", ApiClient.ParameterToString(includeHomeConversions)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPrices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPrices: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20027) ApiClient.Deserialize(response.Content, typeof(InlineResponse20027), response.Headers);
        }
    
        /// <summary>
        /// Trade Details Get the details of a specific Trade in an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="tradeSpecifier">Specifier for the Trade</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 GetTrade (string accountID, string tradeSpecifier, string acceptDatetimeFormat)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling GetTrade");
            
            // verify the required parameter 'tradeSpecifier' is set
            if (tradeSpecifier == null) throw new ApiException(400, "Missing required parameter 'tradeSpecifier' when calling GetTrade");
            
    
            var path = "/accounts/{accountID}/trades/{tradeSpecifier}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
path = path.Replace("{" + "tradeSpecifier" + "}", ApiClient.ParameterToString(tradeSpecifier));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTrade: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTrade: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        /// <summary>
        /// Transaction Details Get the details of a single Account Transaction.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="transactionID">A Transaction ID</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 GetTransaction (string accountID, string transactionID, string acceptDatetimeFormat)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling GetTransaction");
            
            // verify the required parameter 'transactionID' is set
            if (transactionID == null) throw new ApiException(400, "Missing required parameter 'transactionID' when calling GetTransaction");
            
    
            var path = "/accounts/{accountID}/transactions/{transactionID}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
path = path.Replace("{" + "transactionID" + "}", ApiClient.ParameterToString(transactionID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransaction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransaction: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        /// Transaction ID Range Get a range of Transactions for an Account based on the Transaction IDs.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="from">The starting Transacion ID (inclusive) to fetch.</param> 
        /// <param name="to">The ending Transaction ID (inclusive) to fetch.</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="type">The filter that restricts the types of Transactions to retreive.</param> 
        /// <returns>InlineResponse20023</returns>            
        public InlineResponse20023 GetTransactionRange (string accountID, string from, string to, string acceptDatetimeFormat, List<string> type)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling GetTransactionRange");
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling GetTransactionRange");
            
            // verify the required parameter 'to' is set
            if (to == null) throw new ApiException(400, "Missing required parameter 'to' when calling GetTransactionRange");
            
    
            var path = "/accounts/{accountID}/transactions/idrange";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionRange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionRange: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20023) ApiClient.Deserialize(response.Content, typeof(InlineResponse20023), response.Headers);
        }
    
        /// <summary>
        /// Transactions Since ID Get a range of Transactions for an Account starting at (but not including) a provided Transaction ID.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="id">The ID of the last Transacion fetched. This query will return all Transactions newer than the TransactionID.</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <returns>InlineResponse20023</returns>            
        public InlineResponse20023 GetTransactionsSinceId (string accountID, string id, string acceptDatetimeFormat)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling GetTransactionsSinceId");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetTransactionsSinceId");
            
    
            var path = "/accounts/{accountID}/transactions/sinceid";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionsSinceId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionsSinceId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20023) ApiClient.Deserialize(response.Content, typeof(InlineResponse20023), response.Headers);
        }
    
        /// <summary>
        /// User Info Fetch the user information for the specified user. This endpoint is intended to be used by the user themself to obtain their own information.
        /// </summary>
        /// <param name="userSpecifier">The User Specifier</param> 
        /// <returns>InlineResponse20025</returns>            
        public InlineResponse20025 GetUserInfo (string userSpecifier)
        {
            
            // verify the required parameter 'userSpecifier' is set
            if (userSpecifier == null) throw new ApiException(400, "Missing required parameter 'userSpecifier' when calling GetUserInfo");
            
    
            var path = "/users/{userSpecifier}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userSpecifier" + "}", ApiClient.ParameterToString(userSpecifier));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20025) ApiClient.Deserialize(response.Content, typeof(InlineResponse20025), response.Headers);
        }
    
        /// <summary>
        /// Get Order Book Fetch an order book for an instrument.
        /// </summary>
        /// <param name="instrument">Name of the Instrument</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="time">The time of the snapshot to fetch. If not specified, then the most recent snapshot is fetched.</param> 
        /// <returns>InlineResponse2003</returns>            
        public InlineResponse2003 InstrumentsInstrumentOrderBookGet (string instrument, string acceptDatetimeFormat, string time)
        {
            
            // verify the required parameter 'instrument' is set
            if (instrument == null) throw new ApiException(400, "Missing required parameter 'instrument' when calling InstrumentsInstrumentOrderBookGet");
            
    
            var path = "/instruments/{instrument}/orderBook";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "instrument" + "}", ApiClient.ParameterToString(instrument));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (time != null) queryParams.Add("time", ApiClient.ParameterToString(time)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InstrumentsInstrumentOrderBookGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InstrumentsInstrumentOrderBookGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response.Content, typeof(InlineResponse2003), response.Headers);
        }
    
        /// <summary>
        /// Get Position Book Fetch a position book for an instrument.
        /// </summary>
        /// <param name="instrument">Name of the Instrument</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="time">The time of the snapshot to fetch. If not specified, then the most recent snapshot is fetched.</param> 
        /// <returns>InlineResponse2004</returns>            
        public InlineResponse2004 InstrumentsInstrumentPositionBookGet (string instrument, string acceptDatetimeFormat, string time)
        {
            
            // verify the required parameter 'instrument' is set
            if (instrument == null) throw new ApiException(400, "Missing required parameter 'instrument' when calling InstrumentsInstrumentPositionBookGet");
            
    
            var path = "/instruments/{instrument}/positionBook";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "instrument" + "}", ApiClient.ParameterToString(instrument));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (time != null) queryParams.Add("time", ApiClient.ParameterToString(time)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InstrumentsInstrumentPositionBookGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InstrumentsInstrumentPositionBookGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);
        }
    
        /// <summary>
        /// List Accounts Get a list of all Accounts authorized for the provided token.
        /// </summary>
        /// <returns>InlineResponse20015</returns>            
        public InlineResponse20015 ListAccounts ()
        {
            
    
            var path = "/accounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAccounts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAccounts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20015) ApiClient.Deserialize(response.Content, typeof(InlineResponse20015), response.Headers);
        }
    
        /// <summary>
        /// Open Positions List all open Positions for an Account. An open Position is a Position in an Account that currently has a Trade opened for it.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <returns>InlineResponse2006</returns>            
        public InlineResponse2006 ListOpenPositions (string accountID)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling ListOpenPositions");
            
    
            var path = "/accounts/{accountID}/openPositions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListOpenPositions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListOpenPositions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2006) ApiClient.Deserialize(response.Content, typeof(InlineResponse2006), response.Headers);
        }
    
        /// <summary>
        /// List Open Trades Get the list of open Trades for an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <returns>InlineResponse20010</returns>            
        public InlineResponse20010 ListOpenTrades (string accountID, string acceptDatetimeFormat)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling ListOpenTrades");
            
    
            var path = "/accounts/{accountID}/openTrades";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListOpenTrades: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListOpenTrades: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20010) ApiClient.Deserialize(response.Content, typeof(InlineResponse20010), response.Headers);
        }
    
        /// <summary>
        /// List Orders Get a list of Orders for an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="ids">List of Order IDs to retrieve</param> 
        /// <param name="state">The state to filter the requested Orders by</param> 
        /// <param name="instrument">The instrument to filter the requested orders by</param> 
        /// <param name="count">The maximum number of Orders to return</param> 
        /// <param name="beforeID">The maximum Order ID to return. If not provided the most recent Orders in the Account are returned</param> 
        /// <returns>InlineResponse20029</returns>            
        public InlineResponse20029 ListOrders (string accountID, string acceptDatetimeFormat, List<string> ids, string state, string instrument, int? count, string beforeID)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling ListOrders");
            
    
            var path = "/accounts/{accountID}/orders";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
 if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (instrument != null) queryParams.Add("instrument", ApiClient.ParameterToString(instrument)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (beforeID != null) queryParams.Add("beforeID", ApiClient.ParameterToString(beforeID)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListOrders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListOrders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20029) ApiClient.Deserialize(response.Content, typeof(InlineResponse20029), response.Headers);
        }
    
        /// <summary>
        /// Pending Orders List all pending Orders in an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <returns>InlineResponse20030</returns>            
        public InlineResponse20030 ListPendingOrders (string accountID, string acceptDatetimeFormat)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling ListPendingOrders");
            
    
            var path = "/accounts/{accountID}/pendingOrders";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPendingOrders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPendingOrders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20030) ApiClient.Deserialize(response.Content, typeof(InlineResponse20030), response.Headers);
        }
    
        /// <summary>
        /// List Positions List all Positions for an Account. The Positions returned are for every instrument that has had a position during the lifetime of an the Account.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <returns>InlineResponse2005</returns>            
        public InlineResponse2005 ListPositions (string accountID)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling ListPositions");
            
    
            var path = "/accounts/{accountID}/positions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPositions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPositions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2005) ApiClient.Deserialize(response.Content, typeof(InlineResponse2005), response.Headers);
        }
    
        /// <summary>
        /// List Trades Get a list of Trades for an Account
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="ids">List of Trade IDs to retrieve.</param> 
        /// <param name="state">The state to filter the requested Trades by.</param> 
        /// <param name="instrument">The instrument to filter the requested Trades by.</param> 
        /// <param name="count">The maximum number of Trades to return.</param> 
        /// <param name="beforeID">The maximum Trade ID to return. If not provided the most recent Trades in the Account are returned.</param> 
        /// <returns>InlineResponse2009</returns>            
        public InlineResponse2009 ListTrades (string accountID, string acceptDatetimeFormat, List<string> ids, string state, string instrument, int? count, string beforeID)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling ListTrades");
            
    
            var path = "/accounts/{accountID}/trades";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
 if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (instrument != null) queryParams.Add("instrument", ApiClient.ParameterToString(instrument)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (beforeID != null) queryParams.Add("beforeID", ApiClient.ParameterToString(beforeID)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTrades: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTrades: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2009) ApiClient.Deserialize(response.Content, typeof(InlineResponse2009), response.Headers);
        }
    
        /// <summary>
        /// List Transactions Get a list of Transactions pages that satisfy a time-based Transaction query.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="from">The starting time (inclusive) of the time range for the Transactions being queried.</param> 
        /// <param name="to">The ending time (inclusive) of the time range for the Transactions being queried.</param> 
        /// <param name="pageSize">The number of Transactions to include in each page of the results.</param> 
        /// <param name="type">A filter for restricting the types of Transactions to retreive.</param> 
        /// <returns>InlineResponse20021</returns>            
        public InlineResponse20021 ListTransactions (string accountID, string acceptDatetimeFormat, string from, string to, int? pageSize, List<string> type)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling ListTransactions");
            
    
            var path = "/accounts/{accountID}/transactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (to != null) queryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
 if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20021) ApiClient.Deserialize(response.Content, typeof(InlineResponse20021), response.Headers);
        }
    
        /// <summary>
        /// Replace Order Replace an Order in an Account by simultaneously cancelling it and creating a replacement Order
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="orderSpecifier">The Order Specifier</param> 
        /// <param name="replaceOrderBody">Specification of the replacing Order. The replacing order must have the same type as the replaced Order.</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="clientRequestID">Client specified RequestID to be sent with request.</param> 
        /// <returns>InlineResponse2011</returns>            
        public InlineResponse2011 ReplaceOrder (string accountID, string orderSpecifier, ReplaceOrderBody replaceOrderBody, string acceptDatetimeFormat, string clientRequestID)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling ReplaceOrder");
            
            // verify the required parameter 'orderSpecifier' is set
            if (orderSpecifier == null) throw new ApiException(400, "Missing required parameter 'orderSpecifier' when calling ReplaceOrder");
            
            // verify the required parameter 'replaceOrderBody' is set
            if (replaceOrderBody == null) throw new ApiException(400, "Missing required parameter 'replaceOrderBody' when calling ReplaceOrder");
            
    
            var path = "/accounts/{accountID}/orders/{orderSpecifier}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
path = path.Replace("{" + "orderSpecifier" + "}", ApiClient.ParameterToString(orderSpecifier));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
 if (clientRequestID != null) headerParams.Add("ClientRequestID", ApiClient.ParameterToString(clientRequestID)); // header parameter
                        postBody = ApiClient.Serialize(replaceOrderBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceOrder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceOrder: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2011) ApiClient.Deserialize(response.Content, typeof(InlineResponse2011), response.Headers);
        }
    
        /// <summary>
        /// Set Order Extensions Update the Client Extensions for an Order in an Account. Do not set, modify, or delete clientExtensions if your account is associated with MT4.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="orderSpecifier">The Order Specifier</param> 
        /// <param name="setOrderClientExtensionsBody">Representation of the replacing Order</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <returns>InlineResponse20033</returns>            
        public InlineResponse20033 SetOrderClientExtensions (string accountID, string orderSpecifier, SetOrderClientExtensionsBody setOrderClientExtensionsBody, string acceptDatetimeFormat)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling SetOrderClientExtensions");
            
            // verify the required parameter 'orderSpecifier' is set
            if (orderSpecifier == null) throw new ApiException(400, "Missing required parameter 'orderSpecifier' when calling SetOrderClientExtensions");
            
            // verify the required parameter 'setOrderClientExtensionsBody' is set
            if (setOrderClientExtensionsBody == null) throw new ApiException(400, "Missing required parameter 'setOrderClientExtensionsBody' when calling SetOrderClientExtensions");
            
    
            var path = "/accounts/{accountID}/orders/{orderSpecifier}/clientExtensions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
path = path.Replace("{" + "orderSpecifier" + "}", ApiClient.ParameterToString(orderSpecifier));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                        postBody = ApiClient.Serialize(setOrderClientExtensionsBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetOrderClientExtensions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetOrderClientExtensions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20033) ApiClient.Deserialize(response.Content, typeof(InlineResponse20033), response.Headers);
        }
    
        /// <summary>
        /// Set Trade Client Extensions Update the Client Extensions for a Trade. Do not add, update, or delete the Client Extensions if your account is associated with MT4.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="tradeSpecifier">Specifier for the Trade</param> 
        /// <param name="setTradeClientExtensionsBody">Details of how to modify the Trade&#39;s Client Extensions.</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <returns>InlineResponse20013</returns>            
        public InlineResponse20013 SetTradeClientExtensions (string accountID, string tradeSpecifier, SetTradeClientExtensionsBody setTradeClientExtensionsBody, string acceptDatetimeFormat)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling SetTradeClientExtensions");
            
            // verify the required parameter 'tradeSpecifier' is set
            if (tradeSpecifier == null) throw new ApiException(400, "Missing required parameter 'tradeSpecifier' when calling SetTradeClientExtensions");
            
            // verify the required parameter 'setTradeClientExtensionsBody' is set
            if (setTradeClientExtensionsBody == null) throw new ApiException(400, "Missing required parameter 'setTradeClientExtensionsBody' when calling SetTradeClientExtensions");
            
    
            var path = "/accounts/{accountID}/trades/{tradeSpecifier}/clientExtensions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
path = path.Replace("{" + "tradeSpecifier" + "}", ApiClient.ParameterToString(tradeSpecifier));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                        postBody = ApiClient.Serialize(setTradeClientExtensionsBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetTradeClientExtensions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetTradeClientExtensions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20013) ApiClient.Deserialize(response.Content, typeof(InlineResponse20013), response.Headers);
        }
    
        /// <summary>
        /// Set Dependent Orders Create, replace and cancel a Trade&#39;s dependent Orders (Take Profit, Stop Loss and Trailing Stop Loss) through the Trade itself
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="tradeSpecifier">Specifier for the Trade</param> 
        /// <param name="setTradeDependentOrdersBody">Details of how to modify the Trade&#39;s dependent Orders.</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <returns>InlineResponse20014</returns>            
        public InlineResponse20014 SetTradeDependentOrders (string accountID, string tradeSpecifier, SetTradeDependentOrdersBody setTradeDependentOrdersBody, string acceptDatetimeFormat)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling SetTradeDependentOrders");
            
            // verify the required parameter 'tradeSpecifier' is set
            if (tradeSpecifier == null) throw new ApiException(400, "Missing required parameter 'tradeSpecifier' when calling SetTradeDependentOrders");
            
            // verify the required parameter 'setTradeDependentOrdersBody' is set
            if (setTradeDependentOrdersBody == null) throw new ApiException(400, "Missing required parameter 'setTradeDependentOrdersBody' when calling SetTradeDependentOrders");
            
    
            var path = "/accounts/{accountID}/trades/{tradeSpecifier}/orders";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
path = path.Replace("{" + "tradeSpecifier" + "}", ApiClient.ParameterToString(tradeSpecifier));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                        postBody = ApiClient.Serialize(setTradeDependentOrdersBody); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetTradeDependentOrders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetTradeDependentOrders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20014) ApiClient.Deserialize(response.Content, typeof(InlineResponse20014), response.Headers);
        }
    
        /// <summary>
        /// Price Stream Get a stream of Account Prices starting from when the request is made. This pricing stream does not include every single price created for the Account, but instead will provide at most 4 prices per second (every 250 milliseconds) for each instrument being requested. If more than one price is created for an instrument during the 250 millisecond window, only the price in effect at the end of the window is sent. This means that during periods of rapid price movement, subscribers to this stream will not be sent every price. Pricing windows for different connections to the price stream are not all aligned in the same way (i.e. they are not all aligned to the top of the second). This means that during periods of rapid price movement, different subscribers may observe different prices depending on their alignment.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <param name="instruments">List of Instruments to stream Prices for.</param> 
        /// <param name="acceptDatetimeFormat">Format of DateTime fields in the request and response.</param> 
        /// <param name="snapshot">Flag that enables/disables the sending of a pricing snapshot when initially connecting to the stream.</param> 
        /// <returns>InlineResponse20028</returns>            
        public InlineResponse20028 StreamPricing (string accountID, List<string> instruments, string acceptDatetimeFormat, bool? snapshot)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling StreamPricing");
            
            // verify the required parameter 'instruments' is set
            if (instruments == null) throw new ApiException(400, "Missing required parameter 'instruments' when calling StreamPricing");
            
    
            var path = "/accounts/{accountID}/pricing/stream";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (instruments != null) queryParams.Add("instruments", ApiClient.ParameterToString(instruments)); // query parameter
 if (snapshot != null) queryParams.Add("snapshot", ApiClient.ParameterToString(snapshot)); // query parameter
             if (acceptDatetimeFormat != null) headerParams.Add("Accept-Datetime-Format", ApiClient.ParameterToString(acceptDatetimeFormat)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StreamPricing: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StreamPricing: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20028) ApiClient.Deserialize(response.Content, typeof(InlineResponse20028), response.Headers);
        }
    
        /// <summary>
        /// Transaction Stream Get a stream of Transactions for an Account starting from when the request is made.
        /// </summary>
        /// <param name="accountID">Account Identifier</param> 
        /// <returns>InlineResponse20024</returns>            
        public InlineResponse20024 StreamTransactions (string accountID)
        {
            
            // verify the required parameter 'accountID' is set
            if (accountID == null) throw new ApiException(400, "Missing required parameter 'accountID' when calling StreamTransactions");
            
    
            var path = "/accounts/{accountID}/transactions/stream";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountID" + "}", ApiClient.ParameterToString(accountID));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StreamTransactions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StreamTransactions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20024) ApiClient.Deserialize(response.Content, typeof(InlineResponse20024), response.Headers);
        }
    
    }
}
