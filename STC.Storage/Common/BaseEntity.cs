using System.ComponentModel.DataAnnotations;

namespace STC.Storage.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
