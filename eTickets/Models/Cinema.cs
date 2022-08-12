using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int cinemaId { get; set; }
        public string cinemaLogoURL { get; set; }
        public string cinemaName { get; set; }
        public string cinemaDescription { get; set; }
    }
}
