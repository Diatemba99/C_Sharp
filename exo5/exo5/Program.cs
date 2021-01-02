using System;

namespace exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            top:;
            long number = 1;
            do
            {
                Console.WriteLine("Saisissez le nombre: ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number > 20);
           

            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine("Le factoriel est : " + result);
            Console.WriteLine("Voulez-vous effectuer un nouveau calcul ? [oui/non] ");
            string reponse = Convert.ToString(Console.ReadLine());
            
            if(reponse == "oui")
            {
                goto top;
            }
           
        }
    }
}
