using System;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declaration des variables
            float amount = 0;

            // Saisie de la sommes des degats
            try
            {
                Console.WriteLine("Montant des dommages: ");
                amount = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Error > Probleme dans la saisie des valeurs");
                return;
            }

            // Definition de la franchise
            float amount_franchise = amount / 10;

            // Affichage du message...
            if (amount_franchise >= 4000)                                                                                                                           // ...si la franchise est plus grande ou egale a 4000
                Console.WriteLine("Votre assurance va vous rembourser 4000€. Il vous restera a payer " + amount_franchise);
            else                                                                                                                                                    // ...sinon
                Console.WriteLine("Votre assurance va vous rembourser " + amount_franchise + ". Il vous restera a payer " + (amount - amount_franchise));
        }
    }
}