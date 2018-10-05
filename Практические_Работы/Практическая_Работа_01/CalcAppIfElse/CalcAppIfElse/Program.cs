using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAppIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение Калькулятор!");
            Console.WriteLine("Как Вас зовут?");
            string MyName = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + MyName
                + "! Добро пожаловать в систему!");

            string Cmd;
            double First, Second;

            Console.WriteLine("\n" + MyName + ", программа Калькулятор может"
                 + " выполнять следующие команды:");
            Console.WriteLine(" -Plus - сложение; \n -Minus - вычитание; \n -Multiply - умножение; \n -Degree - деление.");
            Console.WriteLine("Какую кокоманды Вы хотите выполнить?");
            Cmd = Console.ReadLine();
            Console.WriteLine("Введите первую переменную:");
            First = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную:");
            Second = double.Parse(Console.ReadLine());

            if (Cmd == "Plus")
            {
                Console.WriteLine("Итоговый результат: " + (First + Second));
            }
            else if (Cmd == "Minus")
            {
                Console.WriteLine("Итоговый результат: " + (First - Second));
            }
            else if (Cmd == "Multiply")
            {
                Console.WriteLine("Итоговый результат: " + (First * Second));
            }
            else if (Cmd == "Degree")
            {
                Console.WriteLine("Итоговый результат: " + (First / Second));
            }

            else
            {
                Console.WriteLine("Команда не входит в список программы.");
            }
            Console.ReadKey();


        }
    }
}
