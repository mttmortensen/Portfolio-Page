using Portfolio_Page.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace Portfolio_Page.Services
{
    public class BlogServices
    {
        private readonly HttpClient _client;

        public BlogServices(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<BlogEntryModel>> GetBlogEntriesAsync(string url) => 
            await _client.GetFromJsonAsync<List<BlogEntryModel>>(url);

    }
}
