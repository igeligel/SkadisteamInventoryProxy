using System.Collections.Generic;

namespace SkadisteamInventoryProxy.Configurations
{
    /// <summary>
    /// Configuration of the application for fetching inventories.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// List of proxies which should be used out of the configuration. This can be left
        /// empty and it will use localhost. Probably interesting for people who are scaling
        /// with Docker on different Server's and IP's.
        /// </summary>
        public List<string> Proxies { get; set; }

        /// <summary>
        /// Time in seconds how long the inventory should be cached. You can set this to 0
        /// for no caching.
        /// </summary>
        public int CacheTime { get; set; }

        /// <summary>
        /// List of community id's to ignore since some inventories should not be cached.
        /// </summary>
        public List<long> CommunityIdsToIgnore { get; set; }
    }
}
