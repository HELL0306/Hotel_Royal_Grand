using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.Models
{
    public class Department
    {
        [Key]
        
        public int Dept_id { get; set; }

        public string dept_name { get; set; }

        public int own_Id { get; set; }

        public OwnerAccount OwnerAccountss { get; set; }
    }
}