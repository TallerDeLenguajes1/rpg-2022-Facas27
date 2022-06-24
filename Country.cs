using System.Text.Json.Serialization;
namespace Juego
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
   // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Capital
    {

        [JsonPropertyName("Name")]
        public string Name { get; set; }
    }

   



    public class Results
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Capital")]
        public Capital Capital { get; set; }


    }

    public class Root
    {

        [JsonPropertyName("Results")]
        public Results Results { get; set; }
    }

}



