using System;

namespace business.BindingModels
{
    public class ComponentBindingModel
    {
        public int? Id { get; set; }
        public String Name { get; set; }
        public String NameFirm { get; set; }
        public Decimal Price { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int SystemUnitId { get; set; }
    }
}
