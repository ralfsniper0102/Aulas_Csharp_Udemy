using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramHotel.Entities.Exceptions;

namespace ProgramHotel.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut<= checkIn)
            {
                throw new DomainException("O check-out deve ser posterior a data de check-in");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn > now || checkOut > now)
            {
                throw new DomainException("Para ser atualizado é necessário as datas serem futuras");

            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("O check-out deve ser posterior a data de check-in");
            }
             
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(
                "Quarto: " + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy, ")
                + Duration()
                );
            if (Duration() > 1)
            {
                sb.Append(" noites");
            }
            else
            {
                sb.Append(" noite");
            }
            return sb.ToString();
        }
    }
}
