using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            double capital, taux, valeur_acquise, annee_placement, date;
            DateTime now = DateTime.Today;
            string display = now.ToString("yyyy");
            date = Convert.ToDouble(display);
            int i = 1;
            Console.WriteLine("Bonjour, veuillez saisir votre capital: ");
            string saisie = Console.ReadLine();
             while (true)
            {
                if (!double.TryParse(saisie, out capital))
                {
                    Console.WriteLine("Saisissez un nombre s'il vous plait");
                }
                else if (capital < 10000)
                {
                    Console.WriteLine("Veuillez fournir un capital supérieur a 10.000: ");
                }
                else
                {
                    break;
                }

                saisie = Console.ReadLine();
            }
            Console.WriteLine("Saisissez le taux de placement de votre capital: ");
            string saisie1 = Console.ReadLine();
            while (true)
            {
                if (!double.TryParse(saisie1, out taux))
                {
                    Console.WriteLine("Saisissez un nombre s'il vous plait");
                }
                else if (taux < 0 || taux > 100 )
                {
                    Console.WriteLine("Saisi invalide ! \nVeuiller saisir un taux compris entre 0 et 100 : ");
                }
                else
                {
                    break;
                }

                saisie1 = Console.ReadLine();
            }
            Console.WriteLine("Saisissez l'année de placement: ");
            string saisie2 = Console.ReadLine();
            while (true)
            {
                if (!double.TryParse(saisie2, out annee_placement))
                {
                    Console.WriteLine("Saisissez un nombre s'il vous plait");
                }
                else if (annee_placement < date || annee_placement > 2050)
                {
                    Console.WriteLine("Veuillez saisir une année courante ou une année a venir (inferieur ou egale à 2050)");
                }
                else
                {
                    break;
                }

                saisie2 = Console.ReadLine();
            }
            valeur_acquise = capital;
            while (capital * 2 > valeur_acquise)
            {
                double interet = fonction.calcul_interet(capital, taux);
                valeur_acquise = valeur_acquise + interet;
                Console.Write("Votre valeur acquise apres la {0} année est de: ", i++);
                Console.WriteLine(valeur_acquise);
            }
        }
    }
}