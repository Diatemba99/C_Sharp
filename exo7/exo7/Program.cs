using System;

namespace exo7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1_Lundi");
            Console.WriteLine("2_Mardi");
            Console.WriteLine("3_Mercredi");
            Console.WriteLine("4_Jeudi");
            Console.WriteLine("5_Vendredi");
            Console.WriteLine("6_Samedi");
            Console.WriteLine("7_Dimanche");

            Console.WriteLine("Faites votre choix en saisissant le numero du jour de la semaine: ");
            int choix = Convert.ToInt32(Console.ReadLine());
            int choixPlat;

            switch (choix)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Bienvenue sur le menu du Lundi");
                    menu();
                    int choixLundi = Convert.ToInt32(Console.ReadLine());

                    switch (choixLundi)
                    {
                        case 1:
                            Console.WriteLine("1-Croissant");
                            Console.WriteLine("2-Pain spaguetti");
                            Console.WriteLine("3-Pain ndambe");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                        case 2:
                            Console.WriteLine("1-Dakhine");
                            Console.WriteLine("2-Caldou");
                            Console.WriteLine("3-etodiaye");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                        case 3:
                            Console.WriteLine("1-Frites");
                            Console.WriteLine("2-Frites porc");
                            Console.WriteLine("3-Viande hachée");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                    }
                    break;


                case 2:
                    Console.Clear();
                    Console.WriteLine("Bienvenue sur le menu du Mardi");
                    menu();
                    int choixMardi = Convert.ToInt32(Console.ReadLine());

                    switch (choixMardi)
                    {
                        case 1:
                            Console.WriteLine("1-Pain");
                            Console.WriteLine("2-Saucicon");
                            Console.WriteLine("3-Corne-boeuf");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                        case 2:
                            Console.WriteLine("1-Thieb jaune");
                            Console.WriteLine("2-Thieb dieune");
                            Console.WriteLine("3-Thieb");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                        case 3:
                            Console.WriteLine("1-Salade");
                            Console.WriteLine("2-Dibi");
                            Console.WriteLine("3-Bolonaise");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                    }
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Bienvenue sur le menu du Mercredi");
                    menu();
                    int choixMercredi = Convert.ToInt32(Console.ReadLine());

                    switch (choixMercredi)
                    {
                        case 1:
                            Console.WriteLine("1-Tapalapa");
                            Console.WriteLine("2-lakh");
                            Console.WriteLine("3-Neuterie");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                        case 2:
                            Console.WriteLine("1-Caldou");
                            Console.WriteLine("2-Chawarma");
                            Console.WriteLine("3-fataya complet");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                        case 3:
                            Console.WriteLine("1-Sauté");
                            Console.WriteLine("2-Thiere Mboume");
                            Console.WriteLine("3-Poulet");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                    }
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Bienvenue sur le menu du Jeudi");
                    menu();
                    int choixJeudi = Convert.ToInt32(Console.ReadLine());

                    switch (choixJeudi)
                    {
                        case 1:
                            Console.WriteLine("1-Fonde");
                            Console.WriteLine("2-Sombi");
                            Console.WriteLine("3-Gari");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                        case 2:
                            Console.WriteLine("1-Yassa Poulet");
                            Console.WriteLine("2-Yassa Poisson");
                            Console.WriteLine("3-Sauce Feuille");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                        case 3:
                            Console.WriteLine("1-Spaguetti");
                            Console.WriteLine("2-Pain Thon");
                            Console.WriteLine("3-Thiere");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                    }
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Bienvenue sur le menu du Vendredi");
                    menu();
                    int choixVendredi = Convert.ToInt32(Console.ReadLine());

                    switch (choixVendredi)
                    {
                        case 1:
                            Console.WriteLine("1-Fonde");
                            Console.WriteLine("2-Sombi");
                            Console.WriteLine("3-Gari");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                        case 2:
                            Console.WriteLine("1-Yassa Poulet");
                            Console.WriteLine("2-Yassa Poisson");
                            Console.WriteLine("3-Sauce Feuille");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                        case 3:
                            Console.WriteLine("1-Spaguetti");
                            Console.WriteLine("2-Pain Thon");
                            Console.WriteLine("3-Thiere");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                    }
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Bienvenue sur le menu du Samedi");
                    menu();
                    int choixSamedi = Convert.ToInt32(Console.ReadLine());

                    switch (choixSamedi)
                    {
                        case 1:
                            Console.WriteLine("1-Fonde");
                            Console.WriteLine("2-Sombi");
                            Console.WriteLine("3-Gari");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                        case 2:
                            Console.WriteLine("1-Yassa Poulet");
                            Console.WriteLine("2-Yassa Poisson");
                            Console.WriteLine("3-Sauce Feuille");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                        case 3:
                            Console.WriteLine("1-Spaguetti");
                            Console.WriteLine("2-Pain Thon");
                            Console.WriteLine("3-Thiere");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                    }
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Bienvenue sur le menu du Dimanche");
                    menu();
                    int choixDimanche = Convert.ToInt32(Console.ReadLine());

                    switch (choixDimanche)
                    {
                        case 1:
                            Console.WriteLine("1-Fonde");
                            Console.WriteLine("2-Sombi");
                            Console.WriteLine("3-Gari");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                        case 2:
                            Console.WriteLine("1-Yassa Poulet");
                            Console.WriteLine("2-Yassa Poisson");
                            Console.WriteLine("3-Sauce Feuille");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                        case 3:
                            Console.WriteLine("1-Spaguetti");
                            Console.WriteLine("2-Pain Thon");
                            Console.WriteLine("3-Thiere");
                            choixPlat = Convert.ToInt32(Console.ReadLine());
                            commande();
                            break;
                    }
                    break;
            }
        }
        static void menu()
        {
            Console.WriteLine("1_petit dejeuner");
            Console.WriteLine("2_dejeuner");
            Console.WriteLine("3_Diner");
        }
        static void commande()
        {
            Console.Clear();
            Console.WriteLine("Votre commande a ete bien pris en charge");
            Console.WriteLine("Nous vous remercions de votre fidelite");
        }
    }
}
