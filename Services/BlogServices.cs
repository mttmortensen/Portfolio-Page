using Portfolio_Page.Models;

namespace Portfolio_Page.Services
{
    public class BlogServices
    {
        private readonly HttpClient _client;

        public BlogServices(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<BlogEntryModel>> GetBlogEntriesAsync() 
        {
            // Logic here soon
        }

    }
}
