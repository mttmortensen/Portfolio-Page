namespace Portfolio_Page.Models
{
    // Using https://api.mortensens.xyz/kc/api/logs as mapping soure
    // Additional props will be added but keeping the source intact.

    public class BlogEntryModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public string Tag { get; set; }
    }
}
