using System;
using System.Collections.Generic;
using System.Text;

namespace business.Interfaces
{
    public interface IBackUp
    {
        void saveSystemUnit(string FolderName);
        void SaveComponent(string FolderName);
    }
}
