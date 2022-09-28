using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration de variables
            double temperature = 0;

            // Saisie des notes
            try
            {
                Console.WriteLine("Temperature de l'eau (en C°):");
                temperature = Convert.ToDouble(Console.Read());
            }
            catch (System.FormatException) 
            {
                Console.WriteLine("Error > Probleme dans la saisie des valeurs");
                return;
            }

            // Affichage du message...
            if (temperature < 0)                                            // ... si la temperature est plus petite que 0
                Console.WriteLine("L'eau est à l'état de glace");
            else if (temperature >= 0 && temperature < 100)                 // ... si la temperature est plus grande ou egale a 0 ET que la temperature est plus petite que 100
                Console.WriteLine("L'eau est à l'état liquide");
            else if (temperature > 100)                                     // ... si la temperature est plus grande que 100
                Console.WriteLine("L'eau est à l'état gazeux");
        }
    }
}