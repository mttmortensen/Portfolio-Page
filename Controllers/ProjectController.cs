using Portfolio_Page.Models;
using Portfolio_Page.Services.Core;

namespace Portfolio_Page.Controllers
{
    public class ProjectController
    {
        private readonly ProjectServices _service;

        public ProjectController(ProjectServices service)
        {
            _service = service;
        }

        public async Task<List<ProjectModel>> GetAll() => await _service.GetAllProjects();

        public async Task<ProjectModel>? GetBySlug(string slug) => await _service.GetProjectBySlug(slug);
    }
}
