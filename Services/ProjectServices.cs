using Portfolio_Page.Models;
using System.Net.Http.Json;

namespace Portfolio_Page.Services
{
    public class ProjectServices
    {
        private readonly HttpClient? _client;

        private List<ProjectModel>? _cachedProjects;

        public ProjectServices(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<ProjectModel>> GetAllProjects() =>
            _cachedProjects = await _client.GetFromJsonAsync<List<ProjectModel>>("data/projects.json");

        public async Task<ProjectModel> GetProjectBySlug(string slug) 
        {
            _cachedProjects = await _client.GetFromJsonAsync<List<ProjectModel>>("data/projects.json");
            return _cachedProjects.FirstOrDefault(p => p.Slug == slug);
        }
    }
}
