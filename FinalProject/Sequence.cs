using System;

namespace numberSequence
{
    class Sequence
    {
        
        public static void fibonacciSequence(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;

                a = b;
                b = temp + b;

                Console.WriteLine(a);
            }
        }
    }
}