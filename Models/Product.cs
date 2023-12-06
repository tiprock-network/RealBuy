using System;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace RealBuy.Models
{
    public class Product
    {
        public string id { get; set; }
        public string title { get; set; }

        
        public string desc { get; set; }
        public string price { get; set; }
        public string company {  get; set; }
        public string logoURL {  get; set; }

        [JsonPropertyName("imgURL")]
        public string imgURL {  get; set; }
        public int[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
        
    }
}
