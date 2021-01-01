using System;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            double  hauteur = 300, bounce = 0;
            while (hauteur > 10)
            {
                bounce++;
                hauteur *= 0.9 ;
            }
            Console.WriteLine("Il faudra de " + bounce + " rebond(s)!");
        }
    }
}
