using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_Project.DAL
{
    internal interface _IReceptionist:IDisposable
    {
        IEnumerable<ReceptionistAccount> GetAllReceptionist();
       ReceptionistAccount GetReceptionistById(int recepid);
        int AddReceptionist(ReceptionistAccount recepEntity);
        int UpdateReceptionist(ReceptionistAccount recepEntity);
        void DeleteReceptionist(int recepId);
    }
}
