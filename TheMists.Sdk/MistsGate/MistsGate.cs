// Copyright (c) 2025 Gustavo Diaz Galeas
// This file is part of TheMists.NET SDK.
//
// Licensed under the GNU AGPL v3.0 (see LICENSE file).
// Additional restriction: This software may not be used for commercial purposes
// without prior written permission from the author.

using System;
//using System.Net.Http;
using System.Text.Json;
using TheMists.Sdk.Models.Commerce;
using TheMists.Sdk.Api;

namespace TheMists.Sdk.MistsGate
{
    public class MistsGate
    {
        public CommerceClient Commerce { get; }

        public MistsGate()
        {
            Commerce = new CommerceClient();
        }
    }
}