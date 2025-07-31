namespace Portfolio_Page.Services.Core
{
    public class SocialLinkServices
    {
        private readonly HttpClient _client;

        public SocialLinkServices(HttpClient client)
        {
            _client = client;
        }
    }
}
