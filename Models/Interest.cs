using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wedu.Models
{
    public class Interest
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<InterestProfile> Profiles { get; set; }
    }
}