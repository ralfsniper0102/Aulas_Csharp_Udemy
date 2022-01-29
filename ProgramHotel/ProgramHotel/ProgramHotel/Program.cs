using ProgramHotel.Entities;
using System;
using System.Collections.Generic;
using ProgramHotel.Entities.Exceptions;

namespace ProgramHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {




            try
            {

                Console.Write("número do quarto: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Data do ckeck-in (dd/mm/aaaa): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Data do ckeck-out (dd/mm/aaaa): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);


                Console.WriteLine(reservation.ToString());


                Console.WriteLine("Entre com os dados para atualizar a reserva: ");


                Console.Write("Data do ckeck-in (dd/mm/aaaa): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Data do ckeck-out (dd/mm/aaaa): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine(reservation.ToString());
            }

            catch (DomainException e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
                
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            /*catch (Exception e) /////general exception
            {
                Console.WriteLine(e.Message);
            }*/


        }
    }
}
