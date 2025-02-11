using System.Text.Json.Serialization;

namespace AppSoftware.Api.Core
{
    public class Question
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        [JsonPropertyName("is_answered")]
        public string IsAnswered { get; set; }

        [JsonPropertyName("view_count")]
        public int ViewCount { get; set; }

        [JsonPropertyName("creation_date")]
        public DateTime CreationDate { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
