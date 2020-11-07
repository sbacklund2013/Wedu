using System;
using System.ComponentModel.DataAnnotations;

namespace Wedu.Models
{
    public class Content
    {
        [Key]
        public int Id { get; set; }
        //Text, Image, Raw Html
        public string Type { get; set; }  
        public string Body { get; set; }

        public int LectureId { get; set; }
        public Lecture Lecture { get; set; }
    }
}