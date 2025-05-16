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
    public class CommerceClient : ApiClient
    {
        const string baseEndpoint = "commerce/prices";

        public async Task<List<int>?> GetAllPriceItemIdsAsync()
        {
            return await GetAsync<List<int>>(baseEndpoint);
        }

        public async Task<Prices?> GetItemBuySellAsync(int id)
        {
            string endpoint = baseEndpoint + $"/{id}";

            return await GetAsync<Prices>(endpoint);
        }

        public async Task<List<Prices?>> GetItemsBuySellAsync(List<int> ids)
        {
            string endpoint = baseEndpoint + "?ids=" + string.Join(",", ids);

            return await GetAsync<List<Prices>>(endpoint);
        }
    }
}