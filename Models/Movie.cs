﻿using System.ComponentModel.DataAnnotations;

namespace Vidly7.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre? Genre { get; set; }

        [Display(Name="Genre")]
        public byte GenreId { get; set; }

        [Required]
        [Display(Name="Release Date")]
        public DateTime DateReleased { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name="Number is Stock")]
        [Range(1,20)]
        public int NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

    }
}
