using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration des variables
            string username = Environment.UserName;
            int hours = DateTime.Now.Hour;
            DayOfWeek days = DateTime.Now.DayOfWeek;

            if ((days == DayOfWeek.Monday && hours > 9) || days == DayOfWeek.Tuesday || days == DayOfWeek.Wednesday || days == DayOfWeek.Thursday || (days == DayOfWeek.Friday && hours < 18))
            {
                if (hours > 9 && hours < 18)
                    Console.WriteLine("Bonjour " + username);
                else
                    Console.WriteLine("Bonsoir " + username);
            }
            else
                Console.WriteLine("Bon week-end " + username);
        }
    }
}