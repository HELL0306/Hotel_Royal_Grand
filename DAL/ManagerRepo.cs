using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.DAL
{
    public class ManagerRepo : _IManager
    {
        private readonly DataContext _context;



        public ManagerRepo(DataContext context)
        {
            _context = context;
        }



        public int AddManager(ManagerAccount manageEntity)
        {
            int result = 0;

            if (manageEntity != null)
            {
                _context.ManagerAccounts.Add(manageEntity);

                _context.SaveChanges();

                result = manageEntity.man_id;
            }
            return result;
        }
            public void DeleteManager(int manid)
        {
            ManagerAccount manageEntity = _context.ManagerAccounts.Find(manid);
            _context.ManagerAccounts.Remove(manageEntity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ManagerAccount> GetAllManager()
        {
            return _context.ManagerAccounts.ToList();
        }

        public ManagerAccount GetManagerById(int manid)
        {
            return _context.ManagerAccounts.Find(manid);
        }

        public int UpdateManage(ManagerAccount manageEntity)
        {
            int result = 0;



            if (manageEntity != null)
            {
                _context.Entry(manageEntity).State = EntityState.Modified;
                _context.SaveChanges();
                result = manageEntity.man_id;
            }
            return result;
        }
    }
}