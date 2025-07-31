using Portfolio_Page.Models;
using System.Net.Http.Json;

namespace Portfolio_Page.Services.Core
{
    public class SocialLinkServices
    {
        private readonly HttpClient _client;

        public SocialLinkServices(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<SocialLinkModel>> GetAllLinks() =>
            await _client.GetFromJsonAsync<List<SocialLinkModel>>("data/social-links.json");
    }
}
