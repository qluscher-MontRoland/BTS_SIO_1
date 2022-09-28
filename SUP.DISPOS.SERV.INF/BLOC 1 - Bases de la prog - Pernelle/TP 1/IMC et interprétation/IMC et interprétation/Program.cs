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
            int weight = 0;
            double height = 0;

            // Saisie des notes
            try
            {
                Console.WriteLine("Poids en kg:");
                weight = Convert.ToInt32(Console.ReadLine());
                if (weight < 30)
                {
                    Console.WriteLine("> Il est fortement conseille de prendre du poids pour atteindre 30KG");
                    return;
                }
                else if (weight > 200)
                {
                    Console.WriteLine("> Il est fortement conseille de perdre du poids pour atteindre 200KG");
                    return;
                }
                Console.WriteLine("Taille en m:");
                height = Convert.ToDouble(Console.ReadLine());
                if (height < 1)
                {
                    Console.WriteLine("> Vous etes plus d'un metre, vous n'etes pas beaucoup, bravo a vous");
                    return;
                }
                else if (height > 3)
                {
                    Console.WriteLine("> Bravo a vous, vous avez depassez Sultan Kösen, qui est l'homme le plus grande du monde");
                    return;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Error > Probleme dans la saisie des valeurs");
                return;
            }

            // Definition de la imc
            double imc = weight / Math.Pow(height, 2);

            // Affichage du message...
            if (imc < 16.5)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Dénutrition");
            }
            else if (imc > 16.5 && imc < 18.5)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("État de maigreur");
            }
            else if (imc > 18.5 && imc < 25)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Corpulence normale");
            }
            else if (imc > 25 && imc < 30)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Surpoids");
            }
            else if (imc > 30 && imc < 35)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Obèsité modérée");
            }
            else if (imc > 35 && imc < 40)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Obèsité sévère");
            }
            else if (imc < 40)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Obèsité morbide");
            }

            // Retour des couleurs par defautl
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            //Console.WriteLine("DEBUG weight > " + weight);
            //Console.WriteLine("DEBUG height > " + height);
            //Console.WriteLine("DEBUG imc > " + imc);
        }
    }
}