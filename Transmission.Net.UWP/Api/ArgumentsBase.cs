﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Transmission.Net.Api
{
    /// <summary>
    /// Absract class for arguments
    /// </summary>
    public abstract class ArgumentsBase
    {
        internal Dictionary<string, object> Data = new Dictionary<string, object>();

        internal object this[string name]
        {
            set => SetValue(name, value);
        }

        private void SetValue(string name, object value)
        {
            if (value == null)
            {
                Data.Remove(name);
            }
            else if (Data.ContainsKey(name))
            {
                Data[name] = value;
            }
            else
            {
                Data.Add(name, value);
            }
        }

        internal T GetValue<T>(string name)
        {
            return Data.ContainsKey(name) ? (T)Data[name] : default;
        }
    }
}
