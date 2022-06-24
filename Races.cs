using System.Text.Json.Serialization;
namespace Juego
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
   // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class ResultadosRaza
    {
  
        [JsonPropertyName("name")]
        public string Name { get; set; }

    }

    public class RaizRazas
    {

        [JsonPropertyName("results")]
        public List<ResultadosRaza> Results { get; set; }
    }

}



