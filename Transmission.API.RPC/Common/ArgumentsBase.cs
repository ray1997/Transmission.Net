﻿namespace Transmission.API.RPC.Common
{
    /// <summary>
    /// Absract class for arguments
    /// </summary>
    public abstract class ArgumentsBase
    {
        internal Dictionary<string, object> Data = new();

        internal object this[string name]
        {
            set => SetValue(name, value);
        }

        private void SetValue(string name, object value)
        {
            if (Data.ContainsKey(name))
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
