using System.Text.Json.Serialization;

namespace AppSoftware.Api.Core
{
    public class LongWait
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
