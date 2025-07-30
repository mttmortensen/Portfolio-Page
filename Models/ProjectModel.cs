namespace Portfolio_Page.Models
{
    public class ProjectModel
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public List<string> TechStack { get; set; } = [];
        public string ImageURL { get; set; }
        public string GHRepoURL { get; set; }
        public string LiveURL { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime DateCompleted { get; set; }
    }
}
