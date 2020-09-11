using System;
using System.ComponentModel.DataAnnotations;

namespace databaseImplement.Models
{
    [Serializable]
    public class Component
    {
        public int Id { get; set; }
        [Required]
        public int SystemUnitId { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String NameFirm { get; set; }
        [Required]
        public Decimal Price { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
        public virtual SystemUnit SystemUnit { get; set; }
    }
}
