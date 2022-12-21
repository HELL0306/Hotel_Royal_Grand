using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Hotel_Management_Project.Models
{
    public class DataContext : DbContext
    {

        public DataContext() : base()
        {


        }
        public  DbSet<Room> Rooms { get; set; }

       
        public  DbSet<Guest> Guests { get; set; }


        public  DbSet<Department> Departments {get;set;}

       

        public DbSet<Reservation> Reservations { get; set; }

      

      

        public DbSet<Bill> Bills { get; set; }


        public DbSet<Inventory> Inventories { get; set; }

        public DbSet<ReceptionistAccount> ReceptionistAccounts { get; set; }

        public DbSet <ManagerAccount> ManagerAccounts { get; set; }

        public DbSet<OwnerAccount> OwnerAccounts { get; set; }



        


    }
}