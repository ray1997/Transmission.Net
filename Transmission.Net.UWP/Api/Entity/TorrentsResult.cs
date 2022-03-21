using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Transmission.Net.Api.Entity
{

    /// <summary>
    /// Contains arrays of torrents and removed torrents
    /// </summary>
    public class TorrentsResult
    {
        public TorrentsResult(TorrentView[] torrents)
        {
            Torrents = torrents;
        }

        /// <summary>
        /// Array of torrents
        /// </summary>
        [JsonProperty("torrents")]
        public TorrentView[] Torrents { get; set; }

        /// <summary>
        /// Array of torrent-id numbers of recently-removed torrents
        /// </summary>
        [JsonProperty("removed")]
        public TorrentView[] Removed { get; set; }

        public static implicit operator TorrentView[](TorrentsResult torrentsResult) { return torrentsResult.Torrents; }
    }
}
