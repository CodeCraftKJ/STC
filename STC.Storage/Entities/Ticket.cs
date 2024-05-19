using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using STC.Storage.Common;

namespace STC.Storage.Entities
{
    [Table("Tickets", Schema = "Cinema")]
    public class Ticket : BaseEntity
    {
        protected Ticket() { }

        public Ticket(string email, int numberOfTickets)
        {
            Email = email;
            NumberOfTickets = numberOfTickets;
        }

        [Required]
        [MinLength(5)]
        [MaxLength(128)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Range(9, 20)]
        public long Phone { get; set; }

        [Range(1, 10)]
        public int NumberOfTickets { get; set; }

        [Required]
        public long SeanceId { get; set; }

        [Required]
        public Seance Seance { get; set; } = null!;
    }
}
