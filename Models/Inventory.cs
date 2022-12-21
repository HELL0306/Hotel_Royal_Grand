using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.Models
{
    public class Inventory
    {
      
        
            [Key]
            
            public int inventory_id { get; set; }

            [Required]
            [StringLength(50)]
            public string item_name { get; set; }

            [Required]
            public int quantity { get; set; }

            [Required]
            public decimal Amount { get; set; }

            [Required]
            public int man_id { get; set; }

            public virtual ManagerAccount ManagerAccounts { get; set; }
        }
    }



