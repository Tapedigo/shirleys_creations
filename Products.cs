using System.Text.Json.Serialization;

namespace shirleys_creations
{
    public class Products
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("price")]
        public int Price { get; set; }
        public string Size { get; set; }
        [JsonPropertyName("ID")]
        public string Id { get; set; }
        public string Description { get; set; }
    }
}