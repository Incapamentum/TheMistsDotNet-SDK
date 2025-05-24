// Copyright (c) 2025 Gustavo Diaz Galeas
// This file is part of TheMists.NET SDK.
//
// Licensed under the GNU AGPL v3.0 (see LICENSE file).
// Additional restriction: This software may not be used for commercial purposes
// without prior written permission from the author.

using TheMists.Sdk.Clients;
using TheMists.Sdk.Interfaces;

namespace TheMists.Sdk.MistsGate
{
    public class MistsGate
    {
        public ICommerceApi Commerce { get; }

        public MistsGate()
        {
            Commerce = new CommerceClient();
        }
    }
}