using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_Project.DAL
{
    internal interface _IManager:IDisposable
    {
        IEnumerable<ManagerAccount> GetAllManager();
        ManagerAccount GetManagerById(int recepid);
        int AddManager(ManagerAccount manageEntity);
        int UpdateManage(ManagerAccount manageEntity);
        void DeleteManager(int manId);

    }
}
