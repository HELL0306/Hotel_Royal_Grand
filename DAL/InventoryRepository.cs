using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.DAL
{
    public class InventoryRepository:_Iinventory
    {
        private readonly DataContext _context;



        public InventoryRepository(DataContext context)
        {
            _context = context;
        }




        public void DeleteInventory(int inventoryid)
        {
            Inventory InventoryEntity = _context.Inventories.Find(inventoryid);
            _context.Inventories.Remove(InventoryEntity);
            _context.SaveChanges();
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }



        public IEnumerable<Inventory> GetAllInventroy()
        {




            return _context.Inventories.ToList();




        }
        public Inventory GetInventoryById(int inventoryid)
        {
            return _context.Inventories.Find(inventoryid);
        }



        public int UpdateInventory(Inventory inventoryEntity)
        {
            int result = -1;



            if (inventoryEntity != null)
            {
                _context.Entry(inventoryEntity).State = EntityState.Modified;
                _context.SaveChanges();
                result = inventoryEntity.inventory_id;
            }
            return result;
        }









        public int AddInventory(Inventory InventoryEntity)
        {
            int result = 0;



            if (InventoryEntity != null)
            {
                _context.Inventories.Add(InventoryEntity);



                _context.SaveChanges();



                result = InventoryEntity.inventory_id;
            }
            return result;
        }




    }
}