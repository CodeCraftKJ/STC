using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using STC.Storage.Common;

namespace STC.Storage.Entities
{
    [Table("MovieCategories", Schema = "Cinema")]
    public class MovieCategory : BaseEntity
    {
        protected MovieCategory() { }

        public MovieCategory(long categoryId, string category)
        {
            CategoryId = categoryId;
            Category = category;
        }

        [Required]
        [MinLength(5)]
        [MaxLength(128)]
        public string Category { get; set; } = string.Empty;

        [Required]
        public long CategoryId { get; set; }
    }
}
