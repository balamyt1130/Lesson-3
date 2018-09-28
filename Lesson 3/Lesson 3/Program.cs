using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Program
    {
        private static int? numbers;

        static void Main(string[] args)
        {
            string HelloWorld = "Hello World";
            string anotherHelloWorld = HelloWorld;

            bool has0 = HelloWorld.Contains("o");

            string HelloWorld2 = null;
            bool? hasl = HelloWorld2?.Contains("L"); // ставим знак вопроса в друх местах что бы избежать ошибку

            int[] numbers = new int[] { 1, 2, 3, 4, };
            int? number3 = numbers?[2];

            int a = 7;
            int b = 6;

            bool isABiggerB = true;
            if (hasFoto)
            {

            }

            string missis= false;
            string name = null;
            string surnme = null;

            string fio = missis ? name + surnme : "MRs" + name + surnme;

            string howToCall = name ?? surnme;
            string howToCall2 = name != null ? name : surnme;
            string howToCall3 = null;

            if (name != null)
            {
                howToCall3 = name;
            }


        }
    }
}
