
using Transmission.Net.Core.Entity.Torrent;

namespace Transmission.Net.Api.Entity.Torrent
{

    public class TorrentFile : ITorrentFile
    {
        public long? BytesCompleted { get; set; }
        public long? Length { get; set; }
        public string Name { get; set; }
    }
}
