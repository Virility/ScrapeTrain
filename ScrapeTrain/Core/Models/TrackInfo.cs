using Newtonsoft.Json;

namespace ScrapeTrain.Core.Models
{
    public class TrackInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("userId")]
        public long UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("lbImage")]
        public string LbImage { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }
    }
}