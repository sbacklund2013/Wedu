using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Wedu.Models
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //Images/HeaderImages
        public string HeaderImagePath { get; set; }
        //enable class to be shown or not
        //"ready" "still working"
        public string Status { get; set; }

        public IList<Subscriber> Subscribers { get; set; }
        public IList<Author> Authors { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }
}
