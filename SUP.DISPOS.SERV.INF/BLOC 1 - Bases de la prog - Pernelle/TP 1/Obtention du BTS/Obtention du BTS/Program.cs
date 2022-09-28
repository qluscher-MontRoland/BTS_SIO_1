using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration des variables
            int note_e1 = 0;
            int note_e2 = 0;
            int note_e3 = 0;
            int note_e4 = 0;
            int note_e5 = 0;
            int note_e6 = 0;

            // Saisie des notes
            try
            {
                Console.WriteLine("Note de E1:");
                note_e1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Note de E2:");
                note_e2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Note de E3:");
                note_e3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Note de E4:");
                note_e4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Note de E5:");
                note_e5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Note de E6:");
                note_e6 = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Error > Probleme dans la saisie des valeurs");
                return;
            }

            // Definition de la moyenne
            int moyenne = (note_e1 + note_e2 + note_e3 + note_e4 + note_e5 + note_e6) / 6;

            // Affichage du message...
            if (moyenne >= 10)                                                              // ...si la moyenne est plus grande ou egale a 10
                Console.WriteLine("\nVous avez votre BTS");
            else if (moyenne < 10 && moyenne > 8)                                           // ...si la moyenne est plus petite a 10 et que la moyenne est plus grande que 8
                Console.WriteLine("\nVous avez encore une change au rattrapage");
            else                                                                            // ...sinon
                Console.WriteLine("\nTu vas devoir refaire une annee en plus...");
            // Console.WriteLine("DEBUG > " + moyenne);
        }
    }
}
