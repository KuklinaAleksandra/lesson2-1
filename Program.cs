using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальзую температуру воздуха за день  ");
            int maxT= Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минимальную температуру воздуха за день  ");
            int minT= Convert.ToInt32(Console.ReadLine());

            int mid = (maxT + minT) / 2;

            Console.Write("Среднесуточная температура составила  " + mid);
        }
    }
}
