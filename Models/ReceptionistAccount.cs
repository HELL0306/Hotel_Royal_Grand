using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.Models
{
    public class ReceptionistAccount
    {
        [Key]
        public int rec_id { get;set;}
      
        [Required]
        [StringLength(50)]
        [DisplayName("Emp_Name")]
        public string emp_name { get; set; }



        [Required, StringLength(50)]
        [DisplayName("Emp_Address")]
        public string emp_address { get; set; }



        [Required]
        [DisplayName("Age")]
        public int age { get; set; }
        [Required]
        [DisplayName("Date_Of_Joining")]
        public DateTime date_of_joining { get; set; }



        [Required]
        [DisplayName("Salary")]
        public decimal salary { get; set; }



        [Required]
        [StringLength(50)]
        [DisplayName("Designation")]
        public string designation { get; set; }



        [Required]
        [StringLength(50)]
        [DisplayName("Mail_Id")]
        public string mail_id { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }

    }
}