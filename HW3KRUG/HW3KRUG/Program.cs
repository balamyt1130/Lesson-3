using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3KRUG
{
    class Program
    {
        static void Main()
        {
            if (DateTime.Now.Hour < 12)
                Console.WriteLine("Good Morning Olga!");
            else
            {
                Console.WriteLine("Good Afternoon Olga!");
            }
            Console.WriteLine("Enter the parameter: circle radius(line) and press Enter!");
            string line = Console.ReadLine();
            bool result = double.TryParse(line, out double r); // TryParse мы преобразуем строковое число в 32-битовое целое число со знаком

            double s = Math.PI * Math.Pow(r, 2);

            Console.WriteLine($"The area of the circle is = {s}");

            if (result == true)
            {

            }
            else
            {
                Console.WriteLine("You entered an invalid value");
            }
            
        }
    }
}
