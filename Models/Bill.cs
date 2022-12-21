using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.Models
{
    public class Bill
    {
        [Key]
        
        public int billing_no { get; set; }



        [Required]
        [StringLength(50)]
        public string Transaction_type { get; set; }



        [Required]




        public decimal Total_Bill { get; set; }



        
        
        [Required]
        public int Reservation_id { get; set; }
        [ForeignKey("Reservation_id")]
        public Reservation Reservations { get; set; }


    }
}