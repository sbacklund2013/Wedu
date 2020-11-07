using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wedu.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public IList<Content> Contents { get; set; }
    }
}
