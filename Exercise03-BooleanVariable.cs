using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            bool word01 = Convert.ToBoolean(word);
            if (word01 == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
