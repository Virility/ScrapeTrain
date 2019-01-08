using AngleSharp.Parser.Html;
using ScrapeTrain.Core.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ScrapeTrain.Core.Providers
{
    public class TrakTrainProvider : IDisposable
    {
        private readonly HttpClient _client;
        private Uri _artistUri;

        public TrakTrainProvider()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://traktrain.com/");
            _client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:65.0) Gecko/20100101 Firefox/65.0");
        }

        public void Dispose()
        {
            _client.Dispose();
        }

        public async Task<ArtistInfo> GetArtistInfo(string name)
        {
            var artistInfo = new ArtistInfo();

            _artistUri = new Uri(_client.BaseAddress, $"/{name}");
            var response = await _client.GetStringAsync($"/{name}");
            if (response.Contains("Not found"))
                return null;

            var parser = new HtmlParser();
            var document = parser.Parse(response);

            artistInfo.Name = document.QuerySelector(".profile-bar__image").GetAttribute("alt");
            foreach (var playerTrackElement in document.QuerySelectorAll("#tracks-container > .player-track"))
            {
                var trackNameElement = playerTrackElement.QuerySelector(".player-track__name");
                if (trackNameElement == null)
                    continue;

                var bareTrackInfo = new BareTrackInfo(_client, _artistUri);
                bareTrackInfo.Name = trackNameElement.TextContent;
                bareTrackInfo.Id = playerTrackElement.GetAttribute("id").Replace("track", string.Empty);
                artistInfo.BareTrackInfos.Add(bareTrackInfo);
            }
            return artistInfo;
        }

        public async Task<byte[]> GetDownloadAsByteArray(TrackInfo trackInfo)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://d2lvs3zi8kbddv.cloudfront.net/" + trackInfo.Link);
            request.Headers.Referrer = _artistUri;

            return await (await _client.SendAsync(request)).Content.ReadAsByteArrayAsync(); 
        }
    }
}