using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracRab07
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Здравствуйте, Вас приветствует Calculator(Nedruzhelubniy interface edition)");
            Console.WriteLine("Введите Первое и Второе число:");
            double[] numbers = new double[2] { double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()) };
            Console.WriteLine("Их можно сложить(+), из Первого можно вычесть Второе(-), Первое можно поделить на Второе(/) и их можно перемножить(*).");
            Console.WriteLine("Выберите действие:");
            string Cmd = Console.ReadLine();
            switch (Cmd)
            {
                case "+":
                    Console.WriteLine(numbers[0] + numbers[1]);
                    break;
                case "-":
                    Console.WriteLine(numbers[0] - numbers[1]);
                    break;
                case "*":
                    Console.WriteLine(numbers[0] * numbers[1]);
                    break;
                case "/":
                    Console.WriteLine(numbers[0] / numbers[1]);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
            Console.ReadKey();
        }
    }
}
