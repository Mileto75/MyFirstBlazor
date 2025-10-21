using System.Text.Json.Serialization;

namespace MyFirstBlazor.Components.Models
{
    public class MovieModel
    {
        [JsonPropertyName("#TITLE")]
        public string TITLE { get; set; }

        [JsonPropertyName("#YEAR")]
        public int YEAR { get; set; }

        [JsonPropertyName("#IMDB_ID")]
        public string IMDB_ID { get; set; }

        [JsonPropertyName("#RANK")]
        public int RANK { get; set; }

        [JsonPropertyName("#ACTORS")]
        public string ACTORS { get; set; }

        [JsonPropertyName("#AKA")]
        public string Aka { get; set; }

        [JsonPropertyName("#IMDB_URL")]
        public string IMDB_URL { get; set; }

        [JsonPropertyName("#IMDB_IV")]
        public string IMDB_IV { get; set; }

        [JsonPropertyName("#IMG_POSTER")]
        public string IMG_POSTER { get; set; }
        public int photo_width { get; set; }
        public int photo_height { get; set; }
    }
}
