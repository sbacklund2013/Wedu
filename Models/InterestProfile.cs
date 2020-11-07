namespace Wedu.Models
{
    public class InterestProfile
    {
        public int InterestId { get; set; }
        public Interest Interest { get; set; }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}