using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Rooms : BaseEntity
    {
        public int RoomNo { get; set; }
        public int FloorNo { get; set; }
        public RoomTypes RoomType { get; set; }
        public bool IsReserved { get; set; } = false;


        public Rooms(Guid Id , int roomNo , int floorNo , RoomTypes roomTypes )
        {
            EntityId = Id;
            RoomNo = roomNo;
            FloorNo = floorNo;
            RoomType = roomTypes;
            CreateDate = new DateTime();
        }


        public Rooms()
        {
            
        }
        public Guid AddNewRoom(int NewRoomNo , int floorNo , Guid roomTypeId)
        {
            Guid RoomId = Guid.NewGuid();
            RoomTypes roomTypes = RoomType.GetRoomTypebyId(roomTypeId);
            Rooms rooms = new Rooms(RoomId,RoomNo , floorNo , roomTypes);
            return RoomId;

        }

        public Rooms GetRoomById(Guid Id)
        {
            Rooms rooms = new Rooms();
            return rooms;
        }

        public void UpdateReservation (Guid RoomId)
        {
            Rooms rooms = GetRoomById(RoomId);
            if (rooms.IsReserved)
                rooms.IsReserved = false;
            else
                rooms.IsReserved = true;
        }
    }
}
