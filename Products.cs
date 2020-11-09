using System.Text.Json.Serialization;

namespace shirleys_creations
{
    public class Products
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("ID")]
        public string Id { get; set; }
        [JsonPropertyName("price")]
        public int Price { get; set; }
        [JsonPropertyName("product-type")]
        public string TypeOfProduct { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Name} {TypeOfProduct}";
        }
    }
}