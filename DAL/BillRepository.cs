using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.DAL
{
    public class BillRepository : _IBillRepository
    {
        private readonly DataContext _context;



        public BillRepository(DataContext context)
        {
            _context = context;
        }
        public int AddBill(Bill billEntity)
        {
            int result = -1;



            if (billEntity != null)
            {
                _context.Bills.Add(billEntity);



                _context.SaveChanges();



                result = billEntity.billing_no;
            }
            return result;
        }



        public void DeleteBill(int billing_no)
        {
            Bill billEntity = _context.Bills.Find(billing_no);
            _context.Bills.Remove(billEntity);
            _context.SaveChanges();
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }



        public IEnumerable<Bill> GetAllBill()
        {
            return _context.Bills.ToList();
        }



        public Bill GetBillById(int id)
        {
            return _context.Bills.Find(id);
        }



        public int UpdateBill(Bill billEntity)
        {
            int result = -1;



            if (billEntity != null)
            {
                _context.Entry(billEntity).State = EntityState.Modified;
                _context.SaveChanges();
                result = billEntity.billing_no;
            }
            return result;
        }
    }
}
