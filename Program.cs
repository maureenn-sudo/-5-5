using System;

namespace _5х5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x5 = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < x5.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < x5.GetLength(1); j++)
                {
                    int Num = rnd.Next(0, 9);
                    x5[i, j] = Num;
                    Console.Write(x5[i, j]);
                }
                Console.WriteLine(x5);

                for (int i2 = 4; i < x5.GetLength(0) + 4; i2++)
                {

                }

            }
            Console.ReadKey();

           

        }
    }
}
  