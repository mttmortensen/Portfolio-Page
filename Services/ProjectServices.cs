using Portfolio_Page.Models;

namespace Portfolio_Page.Services
{
    public class ProjectServices
    {
        private readonly List<ProjectModel> _mockProjets = new() { };

        public List<ProjectModel> GetAllProjects() => _mockProjets;

        public ProjectModel GetProjectBySlug(string slug) =>
            _mockProjets.First(p => p.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

    }
}
