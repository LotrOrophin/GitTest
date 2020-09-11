using business.BindingModels;
using business.Interfaces;
using business.ViewModels;
using databaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace databaseImplement.Implements
{
    public class SystemUnitLogic : ISystemUnitLogic
    {
        public void CreateOrUpdate(SystemUnitBindingModel model)
        {
            using (var context = new Database())
            {
                SystemUnit element = context.SystemUnits.FirstOrDefault(rec => rec.Marka == model.Marka && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть комп с таким названием");
                }
                if (model.Id.HasValue)
                {
                    element = context.SystemUnits.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new SystemUnit();
                    context.SystemUnits.Add(element);
                }
                element.Marka = model.Marka;
                element.DateOfCreate = model.DateOfCreate;
                element.Type = model.Type;
                context.SaveChanges();
            }
        }

        public void Delete(SystemUnitBindingModel model)
        {
            using (var context = new Database())
            {
                SystemUnit element = context.SystemUnits.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.SystemUnits.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<SystemUnitViewModel> Read(SystemUnitBindingModel model)
        {
            using (var context = new Database())
            {
                return context.SystemUnits
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new SystemUnitViewModel
                {
                    Id = rec.Id,
                    Marka = rec.Marka,
                    Type = rec.Type,
                    DateOfCreate = rec.DateOfCreate
                })
                .ToList();
            }
        }
    }
}
