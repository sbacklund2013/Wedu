using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wedu.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Education { get; set; }
        public string Image { get; set; }
        public string IdentityUserId { get; set; }
        public IList<Subscriber> Subscriptions { get; set; }
        public IList<InterestProfile> Interests { get; set; } 
        public IList<Author> Authorships { get; set; }
        public IList<Vote> Votes { get; set; }
    }
}