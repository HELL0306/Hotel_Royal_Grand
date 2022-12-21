using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_Project.DAL
{
    internal interface _IRoomRepository:IDisposable
     {
        IEnumerable<Room> GetAllRoom();

        Room GetRoomById(int roomid);

        int AddRoom(Room roomEntity);

        int updateRoom(Room roomEntity);

        void DeleteRoom(int roomid);

    }
}
