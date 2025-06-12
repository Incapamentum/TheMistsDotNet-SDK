// Copyright (c) 2025 Gustavo Diaz Galeas
// This file is part of TheMists.NET SDK.
//
// Licensed under the GNU AGPL v3.0 (see LICENSE file).
// Additional restriction: This software may not be used for commercial purposes
// without prior written permission from the author.

using TheMists.Sdk.MistsGate;
using TheMists.Sdk.Models.Commerce;
using TheMists.Tests;

public class CommerceUnitTests : BaseTester
{
    private readonly MistsGate _client;

    public CommerceUnitTests()
    {
        _client = new MistsGate();
    }

    [Fact]
    public async Task ErrorTest()
    {
        logger.Info("Executing ErrorTest...");

        Prices p = await _client.Commerce.GetItemPriceAsync(1);
    }
}