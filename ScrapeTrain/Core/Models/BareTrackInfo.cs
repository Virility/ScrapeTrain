using Newtonsoft.Json;
using ScrapeTrain.Core.Providers;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ScrapeTrain.Core.Models
{

    public class BareTrackInfo
    {
        public string Name { get; set; }

        public string Id;

        private HttpClient _client;
        private Uri _artistUri;
  
        public BareTrackInfo(HttpClient client, Uri artistUri)
        {
            _client = client;
            _artistUri = artistUri;
        }

        public async Task<TrackInfo> GetTrackInfo()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/track/{Id}");
            request.Headers.Referrer = _artistUri;

            var response = await (await _client.SendAsync(request)).Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TrackInfo>(response);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}