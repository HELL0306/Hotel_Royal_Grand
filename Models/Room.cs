using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.Models
{
    public class Room
    {
        [Key]
        
        // [ForeignKey("Reservation")]
        [Required(ErrorMessage = "room id is required")]
        public int room_id { get; set; }

       

      
        
        /// <summary>
        /// Name of Which Types of Room
        /// </summary>
        public string RoomTypes { get; set; }

        public decimal roomCharge { get; set; }
       /// <summary>
       /// Room availabel or not if available then 1 otherise 0
       /// </summary>
        public bool RoomStatus { get; set; }

        [Required]
        public int RoomNo { get; set; }


        
        
    }
}