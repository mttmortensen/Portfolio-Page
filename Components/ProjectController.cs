using Portfolio_Page.Models;
using Portfolio_Page.Services;

namespace Portfolio_Page.Components
{
    public class ProjectController
    {
        private readonly ProjectServices _service;

        public ProjectController(ProjectServices service)
        {
            _service = service;
        }

        public List<ProjectModel> GetAll() => _service.GetAllProjects();

        public ProjectModel? GetBySlug(string slug) => _service.GetProjectBySlug(slug);
    }
}
