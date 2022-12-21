using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_Project.DAL
{
    internal interface _IReservationRepo:IDisposable
    {
       
            IEnumerable<Reservation> GetAllReservation();
            Reservation GetReservationById(int deptid);
            int AddReservation(Reservation deptEntity);



            int UpdateReservation(Reservation deptEntity);
            void DeleteReservation(int deptid);




        }
    }
