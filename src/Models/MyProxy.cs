using System;
using System.Net;

namespace SkadisteamInventoryProxy.Models
{
    internal class MyProxy : IWebProxy
    {
        internal MyProxy(string proxyUri) : this(new Uri(proxyUri))
        {}

        internal MyProxy(Uri proxyUri)
        {
            ProxyUri = proxyUri;
        }

        internal Uri ProxyUri { get; set; }

        public ICredentials Credentials { get; set; }

        public Uri GetProxy(Uri destination)
        {
            return ProxyUri;
        }

        public bool IsBypassed(Uri host)
        {
            return false;
        }
    }
}
