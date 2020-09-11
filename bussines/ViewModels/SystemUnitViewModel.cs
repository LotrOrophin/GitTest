using System;
using System.ComponentModel;

namespace business.ViewModels
{
    public class SystemUnitViewModel
    {
        public int Id { get; set; }
        [DisplayName("Марка")]
        public String Marka { get; set; }
        [DisplayName("Тип блок")]
        public String Type { get; set; }
        [DisplayName("Дата создания")]
        public DateTime DateOfCreate { get; set; }
    }
}
