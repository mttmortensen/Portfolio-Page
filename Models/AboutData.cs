namespace Portfolio_Page.Models
{
    public class AboutData
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
        public string PhotoURL { get; set; }
        public string TagLine { get; set; }
        public List<string> SkillsSummary { get; set; } = new List<string>();
        public Dictionary<string, string> SocialLinks { get; set; } = new Dictionary<string, string>();
    }
}
