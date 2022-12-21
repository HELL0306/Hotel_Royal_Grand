using Hotel_Management_Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.DAL
{
    public class ReceptionistRepo : _IReceptionist
    {


        private readonly DataContext _context;



        public ReceptionistRepo(DataContext context)
        {
            _context = context;
        }
       

        public int AddReceptionist(ReceptionistAccount recepEntity)
        {
            int result = 0;

            if(recepEntity != null)
            {
                _context.ReceptionistAccounts.Add(recepEntity);

                _context.SaveChanges();

                result=recepEntity.rec_id;
            }
            return result;
        }

       

        public void DeleteReceptionist(int recepId)
        {
            ReceptionistAccount recepEntity = _context.ReceptionistAccounts.Find(recepId);

            _context.ReceptionistAccounts.Remove(recepEntity);

            _context.SaveChanges();
         }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
     

        public IEnumerable<ReceptionistAccount> GetAllReceptionist()
        {
            return _context.ReceptionistAccounts.ToList();
        }
      
        public ReceptionistAccount GetReceptionistById(int recepid)
        {
            return _context.ReceptionistAccounts.Find(recepid);
        }

        public int UpdateReceptionist(ReceptionistAccount recepEntity)
        {
            int result = -1;



            if (recepEntity != null)
            {
                _context.Entry(recepEntity).State = EntityState.Modified;
                _context.SaveChanges();
                result = recepEntity.rec_id;
            }
            return result;
        }
    }
}