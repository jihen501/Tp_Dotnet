﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationTp3.Models;

namespace Movie.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [Display(Name = " Genre Type ")]
        public int Genresid { get; set; }

        public DateTime? date { get; set; }

        public string ImageURL { get; set; }

        [NotMapped]
        public IFormFile formFile { get; set; }
        public ICollection<Customers>? Customers { get; set; }
        public Genres? Genres { get; set; }
    }
}