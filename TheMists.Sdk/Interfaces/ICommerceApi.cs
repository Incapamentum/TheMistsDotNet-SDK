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
        /// <summary>
        ///     Call to the 'commerce/prices' endpoint.
        /// </summary>
        /// <returns>
        ///     A list of all available IDs.
        /// </returns>
        Task<List<int>?> GetAllPriceItemIdsAsync();

        /// <summary>
        ///     Call to the 'commerce/price/{id}' endpoint
        /// </summary>
        /// <param name="id">
        ///     The ID of the item
        /// </param>
        /// <returns>
        ///     The relevant buy/sell information for the item.
        /// </returns>
        Task<Prices?> GetItemPriceAsync(int id);

        /// <summary>
        ///     Call to the `commerce/price?ids={}` endpoint
        /// </summary>
        /// <param name="ids">
        ///     The list of item IDs
        /// </param>
        /// <returns>
        ///     A list of the buy/sell information for the items
        /// </returns>
        Task<List<Prices>?> GetItemsPricesAsync(List<int> ids);

        /// <summary>
        ///     Call to the 'commerce/listings' endpoint
        /// </summary>
        /// <returns>
        ///     A list of all item IDs with listed buy/sell information
        /// </returns>
        Task<List<int>?> GetAllListingItemIdsAsync();

        /// <summary>
        ///     Call to the 'commerce/listings/{id}' endpoint
        /// </summary>
        /// <param name="id">
        ///     The ID of the item to query for
        /// </param>
        /// <returns>
        ///     The buy/sell information, if applicable, of the item
        /// </returns>
        Task<Listing?> GetItemListingAsync(int id);

        /// <summary>
        ///     Call to the 'commrce/listings?ids={}' endpoint
        /// </summary>
        /// <param name="ids">
        ///     The list of item IDs to query for
        /// </param>
        /// <returns>
        ///     A list of buy/sell, if applicable, of the list of item IDs
        /// </returns>
        Task<List<Listing>?> GetItemsListingAsync(List<int> ids);

        /// <summary>
        ///     Call to the 'commerce/coins?quantity={}` endpoint
        /// </summary>
        /// <param name="c">
        ///     The coins to convert to gems
        /// </param>
        /// <returns></returns>
        Task<ExchangeRate?> GetCoinsToGemsRate(Coins c);

        /// <summary>
        ///     Call to the 'commerce/gems?quantity={}' endpoint
        /// </summary>
        /// <param name="quantity_gems">
        ///     The gems to convert to coins
        /// </param>
        /// <returns></returns>
        Task<ExchangeRate?> GetGemsToCoinsRate(int quantity_gems);
    }
}