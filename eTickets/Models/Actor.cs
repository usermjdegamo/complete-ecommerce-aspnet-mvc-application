using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int actorId { get; set; }
        public string actorProfilePictureURL { get; set; }
        public string actorFullName { get; set; }
        public string actorBio { get; set; }
    }
}
