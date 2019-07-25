using System;
using CustomExceptionAula.Entities;
using CustomExceptionAula.Entities.Exceptions;

namespace CustomExceptionAula {
    class Program {
        static void Main(string[] args) {

            try {


                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (DD/MM/YYYY): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (DD/MM/YYYY): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

                Console.WriteLine(reservation.ToString());

                Console.WriteLine();
                Console.WriteLine("Enter date to update the reservation: ");

                Console.Write("Check-in date (DD/MM/YYYY): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (DD/MM/YYYY): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine(reservation.ToString());
            }catch (DomainException e) {
                Console.WriteLine("Error in reservation: " + e.Message);
            }catch (FormatException e) {
                Console.WriteLine("Format error: " + e.Message);
            }catch (Exception e) {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
