using System;
namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            top:
            int essai = 3;
            Random valeur = new Random();
            int nombreMystere = valeur.Next(100);

            for ( int i = 0; i <3; i++ )
            {
                Console.WriteLine("Saisir un nombre :");
                int val = Convert.ToInt32(Console.ReadLine());

                if(val == nombreMystere)
                {
                    Console.WriteLine("Bravo vous avez trouvé le nombre.");
                    Console.WriteLine("Voulez vous rejouer [oui/non] ? :");
                    string reponse = Convert.ToString(Console.ReadLine());
                    if(reponse =="oui")
                    {
                        goto top;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (val > nombreMystere)
                {
                    essai--;
                    Console.WriteLine(val + " est supérieur au nombre mystere");
                    Console.WriteLine("Il vous reste " + essai +" tentative(s)");
                    
                    if(essai == 0)
                    {
                        Console.WriteLine("Vous avez perdu la manche");
                        Console.WriteLine("Voulez vous rejouer [oui/non] ? :");
                        string reponse = Convert.ToString(Console.ReadLine());
                        if (reponse == "oui")
                        {
                            goto top;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if (val < nombreMystere)
                {
                    essai--;
                    Console.WriteLine(val + " est inférieur au nombre mystere");
                    Console.WriteLine("Il vous reste " + essai + " tentative(s)");

                    if (essai == 0)
                    {
                        Console.WriteLine("Vous avez perdu la manche");
                        Console.WriteLine("Voulez vous rejouer [oui/non] ? :");
                        string reponse = Convert.ToString(Console.ReadLine());
                        if (reponse == "oui")
                        {
                            goto top;
                        }
                        else
                        {
                            break;
                        }
                    }

                }
            }
           

        }
    }
}
