using System.Text.Json.Serialization;

namespace TheMists.Sdk.Models.Commerce
{
    public class PriceEntry
    {
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("unit_price")]
        public int UnitPrice { get; set; }
    }

    public class Prices
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("buys")]
        public required PriceEntry Buys { get; set; }

        [JsonPropertyName("sells")]
        public required PriceEntry Sells { get; set; }
    }
}