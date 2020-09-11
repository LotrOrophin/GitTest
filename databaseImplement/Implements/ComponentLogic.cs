using business.BindingModels;
using business.Interfaces;
using business.ViewModels;
using databaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace databaseImplement.Implements
{
    public class ComponentLogic : IComponentLogic
    {
        public void CreateOrUpdate(ComponentBindingModel model)
        {
            using (var context = new Database())
            {
                Component element = context.Components.FirstOrDefault(rec => rec.Name == model.Name && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть статья с таким названием");
                }
                if (model.Id.HasValue)
                {
                    element = context.Components.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Component();
                    context.Components.Add(element);
                }
                element.Name = model.Name;
                element.NameFirm = model.NameFirm;
                element.Price = model.Price;
                element.SystemUnitId = model.SystemUnitId;
                element.DateCreate = model.DateCreate;
                context.SaveChanges();
            }
        }

        public void Delete(ComponentBindingModel model)
        {
            using (var context = new Database())
            {
                Component element = context.Components.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Components.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<ComponentViewModel> Read(ComponentBindingModel model)
        {
            using (var context = new Database())
            {
                return context.Components
                .Where(rec => model == null 
                || rec.Id == model.Id || rec.SystemUnit.DateOfCreate > model.DateFrom || rec.SystemUnit.DateOfCreate<model.DateTo
                )
                .Select(rec => new ComponentViewModel
                {
                    Id = rec.Id,
                    DateCreate = rec.DateCreate,
                    NameFirm = rec.NameFirm,
                    SystemUnitId = rec.SystemUnitId,
                    Price = rec.Price,
                    Name = rec.Name
                })
                .ToList();
            }
        }
    }
}
