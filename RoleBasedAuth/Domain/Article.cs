namespace Domain
{
    public class Article
    {
        public required uint Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required uint AutherId { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
