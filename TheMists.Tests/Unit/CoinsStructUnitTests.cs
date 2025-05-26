// Copyright (c) 2025 Gustavo Diaz Galeas
// This file is part of TheMists.NET SDK.
//
// Licensed under the GNU AGPL v3.0 (see LICENSE file).
// Additional restriction: This software may not be used for commercial purposes
// without prior written permission from the author.

using System.Runtime.CompilerServices;
using NLog;

using TheMists.Sdk.Models.Commerce;
using TheMists.Tests;

public class CoinsStructUnitTests : BaseTester
{
    [Fact]
    public void CopperValues()
    {
        logger.Info("Executing test CopperValues...");

        Coins c = new Coins(50);

        Assert.NotNull(c);
        Assert.Equal(50, c.Copper);

        c += new Coins(5);

        Assert.Equal(55, c.Copper);

        c -= new Coins(10);

        Assert.Equal(45, c.Copper);

        logger.Info("Completed.");
    }
}