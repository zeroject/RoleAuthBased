namespace Domain
{
    public class Comment
    {
        public required uint Id { get; set; }
        public required string Content { get; set; }
        public required uint ArticleId { get; set; }
        public required uint UserId { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
