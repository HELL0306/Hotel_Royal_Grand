using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.Models
{
    public class Reservation
    {
        [Key]
        
        [Required]
        public int reservation_id { get; set; }

        [Required]
        public int no_of_adults { get; set; }

        [Required]
        public int no_of_child { get; set; }

        [Required(ErrorMessage = "Checkin Date must be filled")]
        public DateTime checkin_date { get; set; }

        [Required(ErrorMessage = "Checkout Date must be filled")]
        public DateTime checkout_date { get; set; }
        /// <summary>
        /// No of staying night in hotel
        /// </summary>
        public int Duration { get; set; }

        [Required(ErrorMessage = "Room id must be filled")]
        public int room_id { get; set; }
        [ForeignKey("room_id")]
        public  Room Rooms { get; set; }

        [Required(ErrorMessage = "receptionist  id must be filled")]

       public int rec_id { get; set; }
        public ReceptionistAccount  ReceptionistAccounts { get; set; }




        public int guest_id { get; set; }

        [ForeignKey("guest_id")]
        public  Guest Guests { get; set; }



      


    }
}