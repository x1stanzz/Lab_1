using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double g = 9.81;
            double t = 0;
            double h;
            double v;
            string option;

            Console.WriteLine("Для знаходження часу вільного падіння, потрібно мати висоту або швидкість");
            Console.WriteLine("Введіть, що відомо: 1 - висота, 2 - швидкість");
            option = Convert.ToString(Console.ReadLine());

            if (option == "1")
            {
                Console.Write("Введіть висоту = ");
                string strh = Console.ReadLine();
                h = double.Parse(strh);
                t = Math.Sqrt((2 * h) / g);
            } 
            else if (option == "2")
            {
                Console.WriteLine("Введіть швидкість = ");
                string strv = Console.ReadLine();
                v = double.Parse(strv);
                t = v / g;
            }
            else
            {
                Console.WriteLine("Спробуйте ще раз!");
                option = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine($"Час дорівнює = {t}");
            Console.Read();
        }
    }
}
