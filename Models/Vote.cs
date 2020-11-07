namespace Wedu.Models
{
    
    public class Vote
    {
        public int ForumPostId { get; set; }
        public ForumPost ForumPost { get; set; }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}