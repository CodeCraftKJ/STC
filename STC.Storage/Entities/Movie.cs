using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using STC.Storage.Common;

namespace STC.Storage.Entities
{
    [Table("Movies", Schema = "Cinema")]
    public class Movie : BaseEntity
    {
        protected Movie() { }

        public Movie(string name, int year, int timeMinutes, string description)
        {
            Name = name;
            Year = year;
            TimeMinutes = timeMinutes;
            Description = description;
            IsActive = true;
            MovieCategories = [];
        }

        [Required]
        [MinLength(3)]
        [MaxLength(128)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Year { get; set; }

        [Required]
        public int TimeMinutes { get; set; }

        [Required]
        [MaxLength(10000)]
        [MinLength(3)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public bool IsActive { get; set; }

        public ICollection<MovieCategory> MovieCategories { get; set; } = [];
    }
}
