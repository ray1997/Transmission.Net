﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Transmission.Net.Api
{

    /// <summary>
    /// Transmission response 
    /// </summary>
    public class TransmissionResponse : CommunicateBase
    {
        [JsonConstructor]
        internal TransmissionResponse(string result)
        {
            Result = result;
        }

        /// <summary>
        /// Contains "success" on success, or an error string on failure.
        /// </summary>
        [JsonProperty("result")]
        public string Result;
    }
}
