using System;
using System.IO;
using System.Text;

namespace Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration des variables
            double delta = 0;
            double a = 0;
            double b = 0;
            double c = 0;

            // Saisie des valeurs
            try
            {
                Console.WriteLine("A:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("B:");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("C:");
                c = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Error > Probleme dans la saisie des valeurs");
                return;
            }

            // Calcul de delta
            delta = (b * b) - (4 * a * c);

            if (delta == 0)                                                                         // si delta est egal a 0
                Console.WriteLine("la solution unique est xs = "+ (-b / (2 * a)));
            else if (delta > 0)                                                                     // si delta > 0
                Console.WriteLine("les deux racines sont : x1 = " + (-b - Math.Sqrt(delta)) / (2 * a) + " et x2 = " + (-b + Math.Sqrt(delta)) / (2 * a));
            else                                                                                   // si delta < 0
                Console.WriteLine("l'equation n admet pas de solution");
        }
    }
}