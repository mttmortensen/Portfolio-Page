using Portfolio_Page.Models;
using Portfolio_Page.Services.Core;

namespace Portfolio_Page.Controllers
{
    public class BlogController
    {
        private readonly BlogServices _service;

        public BlogController(BlogServices service)
        {
            _service = service;
        }

        public async Task<List<BlogEntryModel>> GetAll() => 
            await _service.GetBlogEntriesAsync("https://api.mortensens.xyz/kc/api/logs");

    }
}
