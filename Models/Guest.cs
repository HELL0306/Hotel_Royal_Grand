using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.Models
{
    public class Guest
    {
        [Key] // it is used for making guest_id as primary key
        //here it is used for off identity
        public int guest_id { get; set; }

        [Required]//here maximum lenght will be 50 and must be filled
        [StringLength(50)]
        public string guest_name { get; set; }

        [Required(ErrorMessage = "Email Required")]
        //Email must be in this format
       // [RegularExpression(@"/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/.19-Aug-2022", ErrorMessage = "Wrong email format")]
        [StringLength(20)]
        public string guest_email { get; set; }

        [Required, StringLength(6)]
        public string guest_gender { get; set; }

        [Required]
        [StringLength(30)]
        public string guest_address { get; set; }

        [Required(ErrorMessage = "Mobile Number is required.")]
       // [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Please Enter Valid Mobile Number.")]

        [StringLength(10)]
        public string guest_contact_num { get; set; }




    }
}