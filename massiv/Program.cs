using System;

namespace massiv
{
    class Program
    {
        static void Main()
        {
            int[] Bubble = new int[10];
            for (int i = 0; i < Bubble.Length; i++)
            {
                Random random = new Random();
                Bubble[i] = random.Next(1, 300);
                Console.WriteLine("Значение элемента массива до: " + Bubble[i]);
            }

            for (int x = 0; x < Bubble.Length - 1; x++)
            {
                for (int y = x + 1; y < Bubble.Length; y++)
                {
                    if (Bubble[x] > Bubble[y])
                    {
                        Bubble[x] = Bubble[x] + Bubble[y];
                        Bubble[y] = Bubble[x] - Bubble[y];
                        Bubble[x] = Bubble[x] - Bubble[y];
                    }
                }
                Console.WriteLine("Значение элемента массива после: " + Bubble[x]);
            }
        }
    }
}
