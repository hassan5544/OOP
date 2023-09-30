using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Reservations : BaseEntity
    {
        public Customers Customer { get; set; }
        public Rooms Room { get; set; }
        public Payments Payment { get; set; }

        public DateTime ResStart { get; set; }
        public DateTime ResEnd { get; set; }

        public Reservations(Guid Id ,Customers customers , Rooms rooms , DateTime resStart , DateTime resEnd)
        {
            EntityId = Id;
            Customer = customers;
            Room = rooms;
            ResStart = resStart;
            ResEnd = resEnd;
        }

        public void NewReservation(Guid CustomerId , Guid RoomId , DateTime resStart , DateTime resEnd , decimal rate)
        {
            Guid ReservationId = Guid.NewGuid();
            Customers customer = Customer.GetCustomerbyId(CustomerId);
            Rooms room = Room.GetRoomById(RoomId);
            room.UpdateReservation(RoomId);

            Reservations Reservation = new Reservations(ReservationId, customer, room, resStart, resEnd);

            Guid PaymentId = Payment.AddPayment(room.RoomType.Price , room.RoomType.Price * rate , rate);


        }
    }
}
