using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.Models
{
    public class OwnerAccount
    {
        [Key]
        public int own_Id { get; set; }

        [Required]
        public string ownerEmail { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string password { get; set; }


    }
}