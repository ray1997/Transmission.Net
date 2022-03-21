﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Transmission.Net.Core.Entity;

namespace Transmission.Net.Api.Entity.Torrent
{

    public class TorrentTracker : ITorrentTracker
    {
        [JsonConstructor]
        internal TorrentTracker(string announce, int id, string scrape, int tier)
        {
            Announce = announce;
            Id = id;
            Scrape = scrape;
            Tier = tier;
        }

        public string Announce { get; set; }
        public int Id { get; set; }
        public string Scrape { get; set; }
        public int Tier { get; set; }
    }
}
