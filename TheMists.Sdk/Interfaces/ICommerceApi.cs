// Copyright (c) 2025 Gustavo Diaz Galeas
// This file is part of TheMists.NET SDK.
//
// Licensed under the GNU AGPL v3.0 (see LICENSE file).
// Additional restriction: This software may not be used for commercial purposes
// without prior written permission from the author.

using TheMists.Sdk.Models.Commerce;

namespace TheMists.Sdk.Interfaces
{
    public interface ICommerceApi
    {
        Task<List<int>?> GetAllPriceItemIdsAsync();
        Task<Prices?> GetItemPriceAsync(int id);
        Task<List<Prices>?> GetItemsPricesAsync(List<int> ids);
        Task<List<int>?> GetAllListingItemIdsAsync();
        Task<Listing?> GetItemListingAsync(int id);
        Task<List<Listing>?> GetItemsListingAsync(List<int> ids);
        Task<ExchangeRate?> GetCoinsToGemsRate(int quantity);
        Task<ExchangeRate?> GetGemsToCoinsRate(int quantity);
    }
}