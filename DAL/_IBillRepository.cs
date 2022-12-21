using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.DAL
{
    public interface _IBillRepository : IDisposable
    {
        IEnumerable<Bill> GetAllBill();



        Bill GetBillById(int id);





        int AddBill(Bill billEntity);



        int UpdateBill(Bill billEntity);



        void DeleteBill(int billing_no);


      
    }
}