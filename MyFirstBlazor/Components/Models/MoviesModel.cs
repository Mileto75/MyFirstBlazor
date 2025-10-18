using System.Text.Json.Serialization;

namespace MyFirstBlazor.Components.Models
{
    public class MoviesModel
    {
        [JsonPropertyName("description")]
        public IEnumerable<MovieModel> Movies { get; set; }
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }
    }
}
