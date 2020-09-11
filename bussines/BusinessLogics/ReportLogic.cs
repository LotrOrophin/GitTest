using business.BindingModels;
using business.HelperModels;
using business.Interfaces;
using business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.BusinessLogics
{
    public class ReportLogic
    {
        private readonly ISystemUnitLogic systemUnitLogic;
        private readonly IComponentLogic componentLogic;

        public ReportLogic (ISystemUnitLogic systemUnitLogic, IComponentLogic componentLogic)
        {
            this.systemUnitLogic = systemUnitLogic;
            this.componentLogic = componentLogic;
        }

        public List<ReportViewModel> GetInformation(ReportBindingModel model)
        {

            var components = componentLogic.Read(null);
            var systemUnits = systemUnitLogic.Read(null);
            var list = new List<ReportViewModel>();
            foreach (var component in components)
            {                
                    list.AddRange(systemUnits                        
                        .Select(rec => new ReportViewModel
                        {
                            Marka = rec.Marka,
                            NameComponent = component.Name,
                            NameFirm = component.NameFirm,
                            DateCreate = rec.DateOfCreate,
                            DateUnitCreate = component.DateCreate
                        }).ToList());                    
                
            }
            return list;
        }
        public async void SaveOrdersToPdfFile(ReportBindingModel model)
        {
            await Task.Run(() =>
            {
                SaveToPdf.CreateDoc(new PdfInfo
                {
                    FileName = model.FileName,
                    Title = "Список железок",
                    DateFrom = model.DateFrom.Value,
                    DateTo = model.DateTo.Value,
                    Reports = GetInformation(model)
                });
            });
        }
    }
}
