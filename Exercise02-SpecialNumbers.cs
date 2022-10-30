using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                int digits = i;

                while (digits > 0)
                {
                    sum += digits % 10;
                    digits = digits / 10;
                }
                bool specialNumbers = (sum == 5 || sum == 7 || sum == 11);
                Console.WriteLine("{0} -> {1}", i, specialNumbers);
            }
        }
    }
}
