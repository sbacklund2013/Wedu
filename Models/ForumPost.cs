using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wedu.Models
{
    public class ForumPost
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        //who wrote it
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        //for replies
        public int ParentId { get; set; }
      
        public IList<Vote> Votes { get; set; }
    }
}
