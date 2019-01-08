using AngleSharp.Parser.Html;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ScrapeTrain.Core.Models
{
    public class ArtistInfo
    {
        public string Name { get; set; }

        public List<BareTrackInfo> BareTrackInfos { get; set; }

        public ArtistInfo()
        {
            BareTrackInfos = new List<BareTrackInfo>();
        }
    }
}