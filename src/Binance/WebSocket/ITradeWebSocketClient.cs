﻿using Binance.Client;

namespace Binance.WebSocket
{
    /// <summary>
    /// A trade web socket client.
    /// </summary>
    public interface ITradeWebSocketClient : IBinanceWebSocketClient, ITradeClient
    { }
}
