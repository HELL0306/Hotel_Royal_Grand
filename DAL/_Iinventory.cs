using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management_Project.Models;

namespace Hotel_Management_Project.DAL
{
    internal interface _Iinventory:IDisposable
    {
        IEnumerable<Inventory> GetAllInventroy();
        Inventory GetInventoryById(int inventoryid);
        int AddInventory(Inventory inventoryEntity);
        int UpdateInventory(Inventory inventoryEntity);
        void DeleteInventory(int inventoryid);




    }
}
