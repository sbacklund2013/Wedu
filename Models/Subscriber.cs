using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace Wedu.Models
{
    
    public class Subscriber
    {
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
