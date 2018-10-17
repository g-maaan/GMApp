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
            double x, y, Step = 0;// вводи перую переменную, вторую и переменную, обозначающую кол-во повторений действия

            Console.WriteLine("Введите первое число");
            x = double.Parse(Console.ReadLine());// пользователь вводит первое число
            Console.WriteLine("Введите второе число");
            y = double.Parse(Console.ReadLine());// пользователь вводит второе число
            double z = 1;// вводится переменная, обозначающая прибавление действий
            while (Step < 1000)

            {


                Console.WriteLine((x + y) + ((x + y) * z));// таким образом, каждый раз z возрастает на 1, и к каждой предыдущей сумме двух переменных прибавляется следующая


                Step++;
                z++;
            }
            Console.WriteLine(Step);// выводится кол-во повторений
            Console.ReadLine();
        }
    }
}
