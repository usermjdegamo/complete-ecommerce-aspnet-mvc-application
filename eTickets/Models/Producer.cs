using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int producerId { get; set; }
        public string producerProfilePictureURL { get; set; }
        public string producerFullName { get; set; }
        public string producerBio { get; set; }
    }
}
