using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceWallet
{
    public class api
    {
        public string api_key, secret_key;

        public api(string api,string secret)
        {
            this.api_key = api;
            this.secret_key = secret;
        }
    }
}
