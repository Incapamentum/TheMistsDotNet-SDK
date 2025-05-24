// Copyright (c) 2025 Gustavo Diaz Galeas
// This file is part of TheMists.NET SDK.
//
// Licensed under the GNU AGPL v3.0 (see LICENSE file).
// Additional restriction: This software may not be used for commercial purposes
// without prior written permission from the author.

using System.Text.Json;

namespace TheMists.Sdk.Core
{
    internal class ApiClient
    {
        protected static readonly HttpClient _httpClient;

        static ApiClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.guildwars2.com/v2/")
            };
        }

        protected static async Task<T?> GetAsync<T>(string endpoint)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(json);
        }
    }
}