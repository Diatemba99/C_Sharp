using System;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //DateTime aDate = DateTime.Now;
            Console.WriteLine(DateTime.Now.ToString("dddd dd MMMM yyyy hh:mm:ss"));
            Console.WriteLine(DateTime.Now.AddMinutes(15).ToString("dddd dd MMMM yyyy hh:mm:ss"));
        }
    }
}
