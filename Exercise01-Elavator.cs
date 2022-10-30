using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int maxnumbers = int.Parse(Console.ReadLine());
            int course = (int) Math.Ceiling((double)numbers / maxnumbers);
            Console.WriteLine(course);
        }
    }
}
