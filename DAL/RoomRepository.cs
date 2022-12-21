using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.DAL
{
    public class RoomRepository : _IRoomRepository

    {
        private readonly DataContext _context;

        public RoomRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Room> GetAllRoom()
        {
            return _context.Rooms.ToList();
        }

        public Room GetRoomById(int roomid)
        {
            return _context.Rooms.Find(roomid);
        }


        public int AddRoom(Room roomEntity)
        {
            int result = -1;

            if(roomEntity != null)
            {
                _context.Rooms.Add(roomEntity);

                _context.SaveChanges();

                result = roomEntity.room_id;
            }
            return result;
            
        }

        public void DeleteRoom(int roomid)
        {
            Room RoomEntity = _context.Rooms.Find(roomid);

            _context.Rooms.Remove(RoomEntity);

            _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }




        public int updateRoom(Room roomEntity)
        {

            int result = -1;

            if (roomEntity != null)
            {
                
                _context.Entry(roomEntity).State=System.Data.Entity.EntityState.Modified;

                _context.SaveChanges();

                result = roomEntity.room_id;
            }
            return result;

        }

    }
}