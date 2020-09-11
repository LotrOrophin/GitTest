using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;
using business.Interfaces;
using databaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace databaseImplement.Implements
{
    public class BackUpLogic : IBackUp
    {
        public void saveSystemUnit(string FolderName)
        {
            string fileNameDop = $"{FolderName}\\Authors.xml";
            using (var context = new Database())
            {
                XmlSerializer fomatterXml = new XmlSerializer(typeof(DbSet<SystemUnit>));
                using (FileStream fs = new FileStream(fileNameDop, FileMode.Create))
                {
                    fomatterXml.Serialize(fs, context.SystemUnits);
                }
            }
        }
        public void SaveComponent(string FolderName)
        {
            string fileNameDop = $"{FolderName}\\Components.xml";
            using (var context = new Database())
            {
                XmlSerializer fomatterXml = new XmlSerializer(typeof(DbSet<Component>));
                using (FileStream fs = new FileStream(fileNameDop, FileMode.Create))
                {
                    fomatterXml.Serialize(fs, context.Components);
                }
            }
        }
    }
}
