using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_Project.DAL
{
    internal interface IGuestRepository:IDisposable
    {
        IEnumerable<Guest> GetAllGuest();

       

        Guest GetGuestById(int id);

        int AddGuest(Guest guestEntity);

        int UpdateGuest(Guest guestEntity);

        void DeleteGuest(int guestId);  
    }
}
