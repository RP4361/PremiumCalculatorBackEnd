using System.Text.Json.Serialization;

namespace Domain
{
    public class Occupation
    {
        public int Id { get; set; }

        [JsonPropertyName("occupation")]
        public string? OccupationName { get; set; }

        [JsonPropertyName("rating")]
        public string? Rating { get; set; }

        [JsonPropertyName("factor")]
        public double Factor { get; set; }



    }
}