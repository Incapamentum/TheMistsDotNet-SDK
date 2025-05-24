// Copyright (c) 2025 Gustavo Diaz Galeas
// This file is part of TheMists.NET SDK.
//
// Licensed under the GNU AGPL v3.0 (see LICENSE file).
// Additional restriction: This software may not be used for commercial purposes
// without prior written permission from the author.

using System.Text.Json;
using TheMists.Sdk.Models.Commerce;

namespace TheMists.Sdk.Api
{
    internal class CommerceClient : ApiClient
    {
        const string baseEndpoint = "commerce/";
        const string priceEndpoint = baseEndpoint + "prices";
        const string listingEndpoint = baseEndpoint + "listings";

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
            string endpoint = baseEndpoint + $"/{id}";

            return await GetAsync<Listing>(endpoint);
        }

        public async Task<List<Listing>?> GetItemsListingAsync(List<int> ids)
        {
            string endpoint = baseEndpoint + "?ids=" + string.Join(",", ids);

            return await GetAsync<List<Listing>>(endpoint);
        }


    }
}