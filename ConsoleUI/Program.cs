using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

// Capture information about each guest (assumption is at least one guest and unkown maximum)
// Info to capture: FirstName, LastName, MessageToHost
// Once done, loop thorugh each guest and print their info. 

namespace ConsoleUI
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();

        static void Main(string[] args)
        {

            GetGuestInformation();

            PrintGuestInformation();

            Console.ReadLine();
        }

        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

        private static void GetGuestInformation()
        {
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();
                Console.Write("What is your first name: ");
                guest.FirstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                guest.LastName = Console.ReadLine();

                Console.Write("What message would you like to tell your host: ");
                guest.MessageToHost = Console.ReadLine();

                Console.Write("Are more guests coming (yes/no): ");
                moreGuestsComing = Console.ReadLine();

                guests.Add(guest);

                Console.Clear();

            } while (moreGuestsComing.ToLower() == "yes");
         }
    }
}