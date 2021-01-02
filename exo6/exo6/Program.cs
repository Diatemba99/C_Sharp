using System;

namespace exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            double delta, x1, x2, x0;

            Console.WriteLine("Entrer la premiere valeur: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrer la deuxieme valeur: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrer la troisieme valeur: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                delta = b * b - 4 * a * c;

                if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("La solution est S ={ " + x1 + "," +x2 + "}");
                }
                else if (delta == 0)
                {
                    x0 = -b / (2 * a);
                    Console.WriteLine("La solution est S ={ " + x0 + "}");

                }
                else if (delta < 0)
                {
                    Console.WriteLine("Pas de solution S = { � }");
                }
            }

            else if (a == 0)
            {
                if (b != 0)
                {
                    Console.WriteLine("S = {" + -c /b +  "}");

                }
                else if (b == 0)
                {
                    if (c != 0)
                    {
                        Console.WriteLine("Pas de solution S = { � }");
                    }
                    else
                    {
                        Console.WriteLine("Pas de solution S = { R }");
                    }

                }
            }

        }
    }
}
