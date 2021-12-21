using System;

namespace Laba1_PITPM
{
    class Program
    {
        static void RunTimesTable()
        {
            Console.WriteLine("Введите число: ");
            string Chisl = Console.ReadLine();
            int Chisl_1 = Convert.ToInt32(Chisl);
            while (Chisl_1 % 2 == 0)
            {
                Console.Write("2 X ");
                Chisl_1 = Chisl_1 / 2;
                for (int i = 2; i <= Math.Floor(Math.Sqrt(Chisl_1)); i++)
                {
                    while (Chisl_1 % i == 0)
                    {
                        Console.Write(i + " X ");
                        Chisl_1 = Chisl_1 / i;
                    }
                }
                if (Chisl_1 > 2)
                {
                    Console.Write(Chisl_1);
                }
            }
            while (Chisl_1 % 3 == 0)
            {
                Console.Write("3 X ");
                Chisl_1 = Chisl_1 / 3;
                for (int i = 3; i <= Math.Floor(Math.Sqrt(Chisl_1)); i++)
                {
                    while (Chisl_1 % i == 0)
                    {
                        Console.Write(i + " X ");
                        Chisl_1 = Chisl_1 / i;
                    }
                }
                if (Chisl_1 > 3)
                {
                    Console.Write(Chisl_1);
                }
            }
            if (Chisl_1 % 3 != 0)
            {
                if(Chisl_1 % 2 != 0)
                {
                    Console.WriteLine(Chisl_1);
                }
            }
        }
        static void Main(string[] args)
        {
            RunTimesTable();
        }
    }
}
