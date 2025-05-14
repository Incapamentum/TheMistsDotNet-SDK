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
        public async Task<Prices?> GetPrices(string id)
        {
            string endpoint = "commerce/prices/" + id;

            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Prices>(json);
        }
    }
}