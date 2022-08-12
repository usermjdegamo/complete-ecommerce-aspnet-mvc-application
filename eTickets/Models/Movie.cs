using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int movieId { get; set; }
        public string movieName { get; set; }
        public string movieDescription { get; set; }
        public double moviePrice { get; set; }
        public string movieImageUrl { get; set; }

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public eMovieCategory MovieCategory { get; set; }
    }
}
