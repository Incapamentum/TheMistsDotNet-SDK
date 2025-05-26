// Copyright (c) 2025 Gustavo Diaz Galeas
// This file is part of TheMists.NET SDK.
//
// Licensed under the GNU AGPL v3.0 (see LICENSE file).
// Additional restriction: This software may not be used for commercial purposes
// without prior written permission from the author.

using System.Diagnostics.CodeAnalysis;

namespace TheMists.Sdk.Models.Commerce
{
    public readonly struct Coins : IEquatable<Coins>
    {
        public const int CopperInSilver = 100;
        public const int CopperInGold = 10000;

        public int TotalCopper { get; }

        public Coins(int totalCopper)
        {
            TotalCopper = totalCopper;
        }

        public Coins(int gold, int silver, int copper)
        {
            TotalCopper = (gold * CopperInGold) + (silver * CopperInSilver) + copper; 
        }

        public int Gold => TotalCopper / CopperInGold;
        public int Silver => (TotalCopper % CopperInGold) / CopperInSilver;
        public int Copper => TotalCopper % CopperInSilver;

        public override string ToString() => $"{Gold}g {Silver}s {Copper}c";

        public static Coins FromGoldSilverCopper(int gold, int silver, int copper)
        {
            if (gold < 0 || silver < 0 || copper < 0)
                throw new ArgumentOutOfRangeException("Currency values cannot be negative.");

            if (silver >= 100 || copper >= 100)
                throw new ArgumentException("Silver and copper must be less than 100.");

            return new Coins((gold * 10000) + (silver * 100) + copper);
        }

        public static implicit operator int(Coins c) => c.TotalCopper;
        public static explicit operator Coins(int totalCopper) => new Coins(totalCopper);

        public bool Equals(Coins other) => TotalCopper == other.TotalCopper;
        public override bool Equals(object obj) => obj is Coins other && Equals(other);
        public override int GetHashCode() => TotalCopper.GetHashCode();

        public static bool operator ==(Coins left, Coins right) => left.Equals(right);
        public static bool operator !=(Coins left, Coins right) => !left.Equals(right);
    }
}