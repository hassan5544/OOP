using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class RoomTypes : BaseEntity
    {
        public string RoomTypeName { get; set; } = "";
        public decimal Price { get; set; }
        public int Occupation { get; set; }
        public bool IsSweet { get; set; } 

        public RoomTypes(string roomTypeName , decimal price , int occupation , bool isSweet)
        {
            RoomTypeName = roomTypeName ;
            Price = price ;
            Occupation = occupation ;
            IsSweet = isSweet ;
        }
        public RoomTypes()
        {
            
        }
        public Guid AddNew (string roomTypeName, decimal price, int occupation, bool isSweet)
        {
            Guid NewRoomTypeId = Guid.NewGuid();
            RoomTypes roomTypes = new RoomTypes(roomTypeName, price, occupation, isSweet);
            return NewRoomTypeId;
        }
        public RoomTypes GetRoomTypebyId(Guid Id)
        {
            RoomTypes roomTypes = new RoomTypes();
            return roomTypes;

        }
        public void UpdatePrice(Guid Id ,decimal NewPrice)
        {
            RoomTypes roomType =GetRoomTypebyId(Id);
            roomType.Price = NewPrice;
        }
    }
}
