using System;
using System.ComponentModel;

namespace business.ViewModels
{
    public class ComponentViewModel
    {
        public int Id { get; set; }
        public int SystemUnitId { get; set; }
        [DisplayName("Название")]
        public String Name { get; set; }
        [DisplayName("Название фирмы")]
        public String NameFirm { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }
    }
}
