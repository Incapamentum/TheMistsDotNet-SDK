// Copyright (c) 2025 Gustavo Diaz Galeas
// This file is part of TheMists.NET SDK.
//
// Licensed under the GNU AGPL v3.0 (see LICENSE file).
// Additional restriction: This software may not be used for commercial purposes
// without prior written permission from the author.

using NLog;
using Xunit;

using TheMists.Sdk.MistsGate;
using TheMists.Sdk.Models.Commerce;
using TheMists.Tests;

public class CommerceApiIntegrationTests : BaseTester
{
    private readonly MistsGate _client;

    // Keeps track of the total number of items
    const int TOTAL_ITEM_COUNT = 27813;

    public CommerceApiIntegrationTests()
    {
        _client = new MistsGate();
    }

    [Fact]
    public async Task GetAllPriceItemIdsAsync_ReturnsValidResponse()
    {
        logger.Info("Executing test GetAllPriceItemIdsAsync_ReturnsValidResponse...");

        List<int> result = await _client.Commerce.GetAllPriceItemIdsAsync();

        logger.Info($"Total number of items: {result.Count}");

        Assert.NotNull(result);
        Assert.Equal(TOTAL_ITEM_COUNT, result.Count);

        logger.Info("Completed.");
    }

    [Fact]
    public async Task GetItemPriceAsync_ReturnsValidResponse()
    {
        logger.Info("Executing test GetItemPriceAsync_ReturnsValidResponse...");

        int testItemId = 19721;

        Prices result = await _client.Commerce.GetItemPriceAsync(testItemId);

        Assert.NotNull(result);
        Assert.Equal(testItemId, result.Id);

        Assert.NotNull(result.Buys);
        Assert.True(result.Buys.Quantity >= 0);
        Assert.True(result.Buys.UnitPrice >= 0);

        Assert.NotNull(result.Sells);
        Assert.True(result.Sells.Quantity >= 0);
        Assert.True(result.Sells.UnitPrice >= 0);

        logger.Info("Completed.");
    }

    [Fact]
    public async Task GetItemsPricesAsync_ReturnValidResponse()
    {
        logger.Info("Executing test GetItemsPricesAsync_ReturnValidResponse...");

        List<int> testItemIds = new List<int> { 510, 2322, 12199 };

        List<Prices> result = await _client.Commerce.GetItemsPricesAsync(testItemIds);

        Assert.NotNull(result);
    }
}