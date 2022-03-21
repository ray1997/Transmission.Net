using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Transmission.Net.Core.Util
{

    /// <summary>
    /// Async extension
    /// </summary>
    public static class AsyncExtensions
    {
        /// <summary>
        /// Wait and unwrap exception
        /// </summary>
        /// <param name="task"></param>
        public static void WaitAndUnwrapException(this Task task)
        {
            try
            {
                task.Wait();
            }
            catch (Exception e)
            {
                if (e.InnerException != null)
                {
                    throw e.InnerException;
                }

                throw;
            }
        }
    }
}
