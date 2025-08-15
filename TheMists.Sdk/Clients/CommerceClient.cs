// Copyright (c) 2025 Gustavo Diaz Galeas
// This file is part of TheMists.NET SDK.
//
// Licensed under the GNU AGPL v3.0 (see LICENSE file).
// Additional restriction: This software may not be used for commercial purposes
// without prior written permission from the author.

using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;

using TheMists.Sdk.Core;
using TheMists.Sdk.Interfaces;
using TheMists.Sdk.Models.Commerce;

namespace TheMists.Sdk.Clients
{
    internal class CommerceClient : ApiClient, ICommerceApi
    {
        const string baseEndpoint = "commerce/";
        const string priceEndpoint = baseEndpoint + "prices";
        const string listingEndpoint = baseEndpoint + "listings";
        const string exchangeEndpoint = baseEndpoint + "exchange";

        public async Task<List<int>?> GetAllPriceItemIdsAsync()
        {
            return await GetAsync<List<int>>(priceEndpoint);
        }

        public async Task<Prices?> GetItemPriceAsync(int id)
        {
            string endpoint = priceEndpoint + $"/{id}";

            return await GetAsync<Prices>(endpoint);
        }

        public async Task<List<Prices>?> GetItemsPricesAsync(List<int> ids)
        {
            string endpoint = priceEndpoint + "?ids=" + string.Join(",", ids);

            return await GetAsync<List<Prices>>(endpoint);
        }

        public async Task<List<int>?> GetAllListingItemIdsAsync()
        {
            return await GetAsync<List<int>>(listingEndpoint);
        }

        public async Task<Listing?> GetItemListingAsync(int id)
        {
            string endpoint = listingEndpoint + $"/{id}";

            return await GetAsync<Listing>(endpoint);
        }

        public async Task<List<Listing>?> GetItemsListingAsync(List<int> ids)
        {
            string endpoint = listingEndpoint + "?ids=" + string.Join(",", ids);

            return await GetAsync<List<Listing>>(endpoint);
        }

        // Quantity is the copper amount
        public async Task<ExchangeRate?> GetCoinsToGemsRate(Coins c)
        {
            string endpoint = exchangeEndpoint + $"/coins?quantity={c.TotalCopper}";

            return await GetAsync<ExchangeRate>(endpoint);
        }

        public async Task<ExchangeRate?> GetGemsToCoinsRate(int quantity_gems)
        {
            string endpoint = exchangeEndpoint + $"/gems?quantity={quantity_gems}";

            return await GetAsync<ExchangeRate>(endpoint);
        }
    }
}