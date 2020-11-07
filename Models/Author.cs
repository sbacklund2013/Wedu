namespace Wedu.Models
{
    public class Author
    {
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}