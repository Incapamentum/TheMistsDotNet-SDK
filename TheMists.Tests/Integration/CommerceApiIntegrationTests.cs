// Copyright (c) 2025 Gustavo Diaz Galeas
// This file is part of TheMists.NET SDK.
//
// Licensed under the GNU AGPL v3.0 (see LICENSE file).
// Additional restriction: This software may not be used for commercial purposes
// without prior written permission from the author.

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

using TheMists.Sdk.Api;
using TheMists.Sdk.Models.Commerce;

public class CommerceApiIntegrationTests
{
    private readonly CommerceClient _client;

    public CommerceApiIntegrationTests()
    {
        _client = new CommerceClient();
    }

    [Fact]
    public async Task GetItemPriceAsync_ReturnsValidResponse()
    {
        int testItemId = 19721;

        Prices result = await _client.GetItemPriceAsync(testItemId);

        Assert.NotNull(result);
        Assert.Equal(testItemId, result.Id);

        Assert.NotNull(result.Buys);
        Assert.True(result.Buys.Quantity >= 0);
        Assert.True(result.Buys.UnitPrice >= 0);

        Assert.NotNull(result.Sells);
        Assert.True(result.Sells.Quantity >= 0);
        Assert.True(result.Sells.UnitPrice >= 0);
    }
}