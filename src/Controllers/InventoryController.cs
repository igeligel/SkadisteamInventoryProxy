using System;
using System.Net.Http;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SkadisteamInventoryProxy.Configurations;
using SkadisteamInventoryProxy.Models;

namespace SkadisteamInventoryProxy.Controllers
{
    /// <summary>
    /// Controller for getting inventories.
    /// </summary>
    [Route("api/inventory")]
    public class InventoryController : Controller
    {
        private readonly Configuration _configuration;
        private static int _value = -1;
        private readonly IMemoryCache _cache;

        /// <summary>
        /// Constructor which is needed for some dependency injected Modules.
        /// </summary>
        /// <param name="optionsAccessor">Accessor on the options json file.</param>
        /// <param name="memoryCache">Memory Cache which is registered as service to include it globally so no concurrency issues
        /// are appearing.</param>
        public InventoryController(IOptions<Configuration> optionsAccessor, IMemoryCache memoryCache)
        {
            _configuration = optionsAccessor.Value;
            _cache = memoryCache;
        }

        /// <summary>
        /// Inventory endpoint which will return inventories cached or uncached depending on the configuration.
        /// </summary>
        /// <param name="communityId">Steam Community Id of the inventory's owner which is requested.</param>
        /// <param name="appId">App Id of the inventory's owner which is requested.</param>
        /// <param name="contextId">Context Id of the inventory's owner which is requested.</param>
        /// <returns></returns>
        [HttpGet("{communityId}/{appId}/{contextId}")]
        public string Get(long communityId, int appId, int contextId)
        {
            var key = $"{communityId}-{appId}-{contextId}";
            if ((_configuration.CommunityIdsToIgnore == null ||
                 !_configuration.CommunityIdsToIgnore.Contains(communityId)) &&
                _cache.TryGetValue(key, out string response)) return response;

            response = GetSteamInventory(communityId, appId, contextId);

            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(DateTime.Now.AddSeconds(_configuration.CacheTime));
            _cache.Set(key, response, cacheEntryOptions);
            return response;
        }

        private string GetSteamInventory(long communityId, int appId, int contextId)
        {
            var index = Interlocked.Increment(ref _value);
            var inventoryUrl =
                $"http://steamcommunity.com/inventory/{communityId}/{appId}/{contextId}?l=english&count=5000";
            HttpClient client;
            if (_configuration.Proxies != null)
            {
                var config = new HttpClientHandler
                {
                    UseProxy = true,
                    Proxy = new MyProxy(
                        $"http://{_configuration.Proxies[index % _configuration.Proxies.Count]}")
                };
                client = new HttpClient(config);
            }
            else
            {
                client = new HttpClient();
            }

            return client.GetAsync(inventoryUrl)
                .Result.Content.ReadAsStringAsync()
                .Result;
        }
    }
}
