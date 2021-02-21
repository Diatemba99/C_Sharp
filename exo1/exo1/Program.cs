using System;

namespace exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int montantCapital , tauxPlacement, annee;
            double interet;
            do
            {
                Console.WriteLine("Saisir le montant de votre capital : ");
                montantCapital = Convert.ToInt32(Console.ReadLine());
                if(montantCapital < 10000)
                {
                    Console.WriteLine("veuillez saisir à nouveau votre capital !");
                }
            } while (montantCapital < 10000);

            do
            {
                Console.WriteLine("Saisir le taux de placement : ");
                tauxPlacement = Convert.ToInt32(Console.ReadLine());
                if (tauxPlacement < 0 || tauxPlacement > 100)
                {
                    Console.WriteLine("taux de placement incorrect!");
                }
            } while (tauxPlacement < 0 || tauxPlacement > 100);

            do
            {
                Console.WriteLine("Saisir l'annee de placement : ");
                annee = Convert.ToInt32(Console.ReadLine());
                if (annee < 2020)
                {
                    Console.WriteLine("Veuillez saisir une année courante oú une année à venir svp");
                }

            } while (annee < 2020);

            double montantTotal = montantCapital;
            while ( montantCapital * 2 > montantCapital )
            {
                interet = montantCapital * tauxPlacement / 100;
                montantTotal += montantTotal + interet;
                Console.WriteLine(montantTotal);
            }
        }
    }
}
