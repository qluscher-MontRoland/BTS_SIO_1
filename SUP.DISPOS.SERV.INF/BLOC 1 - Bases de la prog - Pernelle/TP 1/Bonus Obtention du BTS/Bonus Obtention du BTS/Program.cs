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
            int note_e1 = 0;
            int note_e2 = 0;
            int note_e3 = 0;
            int note_e4 = 0;
            int note_e5 = 0;
            int note_e6 = 0;
            String path = null;

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
            else if (note_e1 >= 10 || note_e2 >= 10 || note_e3 >= 10 || note_e4 >= 10 || note_e5 >= 10 || note_e6 >= 10)                                                                           // ...sinon
            {
                Console.WriteLine("\nTu vas devoir refaire une annee en plus... \nJe te conseilles de garder les matieres :");
                if (note_e1 >= 10)
                    Console.WriteLine("- E1: Culture et Communication (" + note_e1 + " / 20)");
                if (note_e2 >= 10)
                    Console.WriteLine("- E2: Mathematique pour l'informatique (" + note_e2 + " / 20)");
                if (note_e3 >= 10)
                    Console.WriteLine("- E3: Culture economique, juridique et manageriale pour l'informatique (" + note_e3 + " / 20)");
                if (note_e4 >= 10)
                    Console.WriteLine("- E4: Support et mise a disposition de servicess informatiques (" + note_e4 + " / 20)");
                if (note_e5 >= 10)
                    Console.WriteLine("- E5: Conception et developpement d'application (" + note_e5 + " / 20)");
                if (note_e6 >= 10)
                    Console.WriteLine("- E6: Cybersecurite des services informatiques (" + note_e6 + " / 20)");
            }
            else
                Console.WriteLine("Vous ne pouvez pas garder de matieres pour l'an prochain, vous n'avez pas de note assez haute");

            try
            {
                Console.WriteLine("Entre le chemin pour votre relevé de note (ex: C:\\Users\\Desktop)");
                path = Console.ReadLine();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Error > Probleme dans la saisie des valeurs");
                return;
            }

            try
            {
                using (FileStream fs = File.Create(path + "\\ReleveDeNote.html"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n\t<meta charset='utf-8'>\r\n\t<title>Relevé de note</title>\r\n</head>\r\n<body style='margin: 0; padding: 0; background: #202020;'>\r\n\t<div style='width:400px; margin:0 auto; margin-top:10%;'>\r\n\t\t<div style='width:100%; padding: 30px; border: 1px solid #fff; background: #fff; box-shadow: 0 0 20px 0 #00000033, 0 5px 5px 0 #0000003d; border-radius: 10px;'>\r\n\t\t\t<p style='margin: 0 auto; margin-bottom: 15px;'>E1: Culture et Communication</p>\r\n\t\t\t<p style='width:38%; margin: 0 auto; margin-bottom: 15px;'>" + note_e1 + " / 20</p>\r\n\t\t\t<br>\r\n\t\t\t<p style='margin: 0 auto; margin-bottom: 15px;'>E2: Mathematique pour l'informatique</p>\r\n\t\t\t<p style='width:38%; margin: 0 auto; margin-bottom: 15px;'>" + note_e2 + " / 20</p>\r\n\t\t\t<br>\r\n\t\t\t<p style='margin: 0 auto; margin-bottom: 15px;'>E3: Culture economique, juridique et manageriale pour l'informatique</p>\r\n\t\t\t<p style='width:38%; margin: 0 auto; margin-bottom: 15px;'>" + note_e3 + " / 20</p>\r\n\t\t\t<br>\r\n\t\t\t<p style='margin: 0 auto; margin-bottom: 15px;'>E4: Support et mise a disposition de servicess informatiques</p>\r\n\t\t\t<p style='width:38%; margin: 0 auto; margin-bottom: 15px;'>" + note_e4 + " / 20</p>\r\n\t\t\t<br>\r\n\t\t\t<p style='margin: 0 auto; margin-bottom: 15px;'>E5: Conception et developpement d'application</p>\r\n\t\t\t<p style='width:38%; margin: 0 auto; margin-bottom: 15px;'>" + note_e5 + " / 20</p>\r\n\t\t\t<br>\r\n\t\t\t<p style='margin: 0 auto; margin-bottom: 15px;'>E6: Cybersecurite des services informatiques</p>\r\n\t\t\t<p style='width:38%; margin: 0 auto; margin-bottom: 15px;'>" + note_e6 + " / 20</p>\r\n\t\t\t<p style='margin: 5px; color: #e1e1e1;'>Par Quentin Luscher</p>\r\n\t\t</div>\r\n\t</div>\r\n</body>\r\n</html>");
                    fs.Write(info, 0, info.Length);
                }
                Console.WriteLine("Votre relevé de note est disponible dès à présent disponible (" + path + "ReleveDeNote.html)");
            }

            catch (Exception)
            {
                Console.WriteLine("Error > Probleme viens surement du faite que le chemin est incorrect ou que l'executable n'a pas la permission de cree le fichier a cette endroit ");
            }
        }
    }
}
