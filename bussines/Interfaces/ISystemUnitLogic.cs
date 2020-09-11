using business.BindingModels;
using business.ViewModels;
using System.Collections.Generic;

namespace business.Interfaces
{
    public interface ISystemUnitLogic
    {
        List<SystemUnitViewModel> Read(SystemUnitBindingModel model);
        void CreateOrUpdate(SystemUnitBindingModel model);
        void Delete(SystemUnitBindingModel model);
    }
}
