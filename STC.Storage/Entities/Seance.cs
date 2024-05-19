using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using STC.Storage.Common;

namespace STC.Storage.Entities
{
    [Table("Seances", Schema = "Cinema")]
    public class Seance : BaseEntity
    {
        protected Seance()
        {
            Tickets = [];
            Movies = [];
        }

        public Seance(DateTime date, long movieId, int numberOfTickets)
        {
            Date = date;
            MovieId = movieId;
            NumberOfTickets = numberOfTickets;
            Tickets = [];
            Movies = [];
        }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int NumberOfTickets { get; set; }

        [Required]
        public long MovieId { get; set; }

        [Required]
        public Movie Movie { get; set; } = null!;

        public ICollection<Ticket> Tickets { get; set; } = [];

        public ICollection<Movie> Movies { get; set; } = [];
    }
}
