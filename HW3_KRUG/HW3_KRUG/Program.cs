using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_KRUG
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour < 12)
                Console.WriteLine("Доброе утро Ольга!");
            else
            {
                Console.WriteLine("Добрый день Ольга!");
            }

        }
    }
}
