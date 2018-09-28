using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3PRACTICE
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b; // сложение двух слогаемых
        }

        static void Main()
        {
            int z = Add(20, 5);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
