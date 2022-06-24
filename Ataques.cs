using System.Text.Json.Serialization;
namespace Juego
{
   // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class ResultadoAtaque
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

      
    }

    public class RaizAtaque
    {


        [JsonPropertyName("results")]
        public List<ResultadoAtaque> Results { get; set; }
    }


}



