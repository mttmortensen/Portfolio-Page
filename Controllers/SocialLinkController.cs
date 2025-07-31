using Portfolio_Page.Models;
using Portfolio_Page.Services.Core;

namespace Portfolio_Page.Controllers
{
    public class SocialLinkController
    {
        private readonly SocialLinkServices _service;

        public SocialLinkController(SocialLinkServices service)
        {
            _service = service;
        }

        public async Task<List<SocialLinkModel>> GetAll() => await _service.GetAllLinks();
    }
}
