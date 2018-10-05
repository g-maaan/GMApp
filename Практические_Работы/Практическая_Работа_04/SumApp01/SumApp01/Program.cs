using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, Step = 0;

            Console.WriteLine("Введите первое число");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            y = double.Parse(Console.ReadLine());
            double z = 1;
            while (Step < 1000)

            {


                Console.WriteLine((x + y) + ((x + y) * z));


                Step++;
                z++;
            }
            Console.WriteLine(Step);
            Console.ReadLine();
        }
    }
}
