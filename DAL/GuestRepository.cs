using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.DAL
{
    public class GuestRepository:IGuestRepository
    {
        private readonly DataContext _context;

        public GuestRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Guest> GetAllGuest()

        {
            return _context.Guests.ToList();
        }

        public Guest GetGuestById(int guestid)
        {
            return _context.Guests.Find(guestid);
        }

        public int AddGuest(Guest guestEntity)
        {
            int result = -1;

            if (guestEntity != null)
            {
                _context.Guests.Add(guestEntity);

                _context.SaveChanges();

                result = guestEntity.guest_id;
            }
            return result;
        }

        public int UpdateGuest(Guest guestEntity)
        {
            int result = -1;

            if (guestEntity != null)
            {

                _context.Entry(guestEntity).State = System.Data.Entity.EntityState.Modified;

                _context.SaveChanges();

                result = guestEntity.guest_id;
            }
            return result;
        }

        public void DeleteGuest(int guestId)
        {
            Guest guest = _context.Guests.Find(guestId);

            _context.Guests.Remove(guest);

            _context.SaveChanges();

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        
    }
}