using System;

namespace hw1Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            //ektupwsh dentrou 5 komvwn-perittoi komboi:symbols-artioi komboi:kena
            Console.WriteLine("Enter symbol");
            char symbol = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------");
            RrintTree(height, symbol);

        }



        static void RrintTree(int h, char sign)
        {
            int z;
            int i = 1;
            do
            {
                z = i % 2;
                if (i == 1)
                {
                    Console.Write("  *  ");
                }
                else if (z == 1)
                {
                    int mesos = (h + 1) / 2;
                    for (int l = 0; l <= mesos - i; l++)
                        Console.Write(" ");
                    for (int k = 0; k < i; k++)
                        Console.Write(sign);
                    for (int d = mesos + 1; d <= mesos + i; d++)
                        Console.Write(" ");

                }
                else
                {
                    Console.Write(" ");
                    Console.WriteLine();
                }
                i = i + 1;
            } while (i <= h);
            Console.WriteLine();
        }
    }
}
