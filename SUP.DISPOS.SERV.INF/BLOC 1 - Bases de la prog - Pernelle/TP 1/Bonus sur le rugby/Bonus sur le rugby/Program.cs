using System;
using System.IO;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace Exercice
{

    // Prototicage de l'objet
    public class Team
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Essais { get; set; }
        public int Points { get; set; }
        public Team(string name, int score, int essais)
        {
            Name = name;
            Score = score;
            Essais = essais;
            Points = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Decleration des objets
            Team team1 = new Team("", 0, 0);
            Team team2 = new Team("", 0, 0);

            // Saisie des informations de l'objet
            try 
            {
                Console.WriteLine("Nom de l'equipe n°1:");
                team1.Name = Console.ReadLine();
                Console.WriteLine("Score de l'equipe n°1:");
                team1.Score = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Nombre d'essais de l'equipe n°1:");
                team1.Essais = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Nom de l'equipe n°2:");
                team2.Name = Console.ReadLine();
                Console.WriteLine("Score de l'equipe n°2:");
                team2.Score = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Nombre d'essais de l'equipe n°2:");
                team2.Essais = Convert.ToInt16(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Error > Probleme dans la saisie des valeurs");
                return;
            }

            // Si victoire
            if (team1.Score > team2.Score) // de l'equipe 1 +4 points
            {
                team1.Points += 4;
                if (team1.Score >= (team2.Score + 5)) // Defaite de l'equipe avec 5 points ou moins de diff +1 points
                    team2.Points++;
            }
            else if (team1.Score < team2.Score) // de l'equipe 2 +4 points
            {
                team1.Points += 4;
                if (team2.Score >= (team1.Score + 5)) // Defaite de l'equipe avec 5 points ou moins de diff +1 points
                    team1.Points++;
            }
            else if (team1.Score == team2.Score)  // aucune (match nul) +2 points au 2 
            {
                team1.Points += 2;
                team2.Points += 2;
            }

            // Si le nombre d'essai est >=  a l'autre equipe+3 +1 point
            if (team1.Essais >= (team2.Score + 3))
                team1.Points++;
            else if (team2.Essais >= (team1.Score + 3))
                team2.Points++;

            // Affiche le nombre de points
            Console.WriteLine("Le match permet a l'equipe " + team1.Name + " d'ajouter " + team1.Points + " points au classement du top 14");
            Console.WriteLine("et l'equipe " + team2.Name + " d'ajouter " + team2.Points + " points au classement du top 14");
        }
    }
}
