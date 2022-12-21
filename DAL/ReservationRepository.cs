using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.DAL
{
    public class ReservationRepository : _IReservationRepo
    {
        private readonly DataContext _context;



        public ReservationRepository(DataContext context)
        {
            _context = context;
        }



        public int AddReservation(Reservation reservationEntity)
        {
            int result = -1;



            if (reservationEntity != null)
            {
                _context.Reservations.Add(reservationEntity);



                _context.SaveChanges();



                result = reservationEntity.reservation_id;
            }
            return result;
        }



        public void DeleteReservation(int reserid)
        {

            Reservation reservationEntity = _context.Reservations.Find(reserid);
            _context.Reservations.Remove(reservationEntity);
            _context.SaveChanges();



        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }



        public IEnumerable<Reservation> GetAllReservation()
        {
            return _context.Reservations.ToList();
        }



        public Reservation GetReservationById(int deptid)
        {
            return _context.Reservations.Find(deptid);
        }



        public int UpdateReservation(Reservation reserEntity)
        {
            int result = -1;



            if (reserEntity != null)
            {
                _context.Entry(reserEntity).State = EntityState.Modified;
                _context.SaveChanges();
                result = reserEntity.reservation_id;
            }
            return result;
        }
    }
}