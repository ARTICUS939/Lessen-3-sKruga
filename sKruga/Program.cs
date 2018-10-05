using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sKruga
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите радиус круга: ");

            int r;

            r = int.Parse(Console.ReadLine());

            double sKruga = Math.PI * r * r;       // искал как красиво представить число пи - наткнулся на чудесный класс Math)

            Console.WriteLine("Площадь круга: " + sKruga);

            Console.ReadLine();
        }
    }
}
