Transmission-RPC-API-CSharp
===========================

Transmission RPC API C# [![Build Status](https://travis-ci.org/Beatlegger/Transmission.API.RPC.svg?branch=master)](https://travis-ci.org/Beatlegger/Transmission.API.RPC)

[Official Transmission RPC specs](https://github.com/transmission/transmission/blob/master/extras/rpc-spec.txt) 

C# implementation of the Transmission RPC API.

| Command              | Not Implemented | Implemented|
| -------------------- |:-:|:-:|
| torrent-start        |   | x |
| torrent-start-now    |   | x |
| torrent-stop         |   | x |
| torrent-verify       |   | x |
| torrent-reannounce   |   | x |
| torrent-set          |   | x |
| torrent-get          |   | x |
| torrent-add          |   | x |
| torrent-remove       |   | x |
| torrent-set-location |   | x |
| torrent-rename-path  |   | x |
| session-set          |   | x |
| session-get          |   | x |
| session-stats        |   | x |
| blocklist-update     |   | x |
| port-test            |   | x |
| session-close        |   | x |
| queue-move-top       |   | x |
| queue-move-up        |   | x |
| queue-move-down      |   | x |
| queue-move-bottom    |   | x |
| free-space           |   | x |

How to use
-------------

Install Nuget Package: `PM> Install-Package Transmission.API.RPC`

```C#
using Transmission.API.RPC.Entity;

// URL might look like "schema://host:port/transmission/rpc" for example "https://website.com:9091/transmission/rpc"
var client = new Client("URL", "PARAM_SESSION_ID", "PARAM_LOGIN", "PARAM_PASS");

var sessionInfo = client.GetSessionInformation();
var allTorrents = client.TorrentGet(TorrentFields.ALL_FIELDS);
//<...>
```
