namespace IGAutoScraper
{
    public class User
    {
        public string Username { get; set; }
        public ScrapeType ScrapeType { get; set; }

        public override string ToString()
        {
            return $"User {{{Username}, {ScrapeType.ToString()}}}";
        }
    }
}