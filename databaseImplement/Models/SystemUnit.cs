using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace databaseImplement.Models
{
    [Serializable]
    public class SystemUnit
    {
        public int Id { get; set; }
        [Required]
        public String Marka { get; set; }
        [Required]
        public String Type { get; set; }
        [Required]
        public DateTime DateOfCreate { get; set; }        
        public virtual List<Component> Components { get; set; }
    }
}
