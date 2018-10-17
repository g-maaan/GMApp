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
            string MyName = Console.ReadLine();// вводим переменную обозначающую ваше имя
            Console.WriteLine("Здравствуйте, " + MyName
                + "! Добро пожаловать в систему!");

            string Cmd;// вводим переменную обозначающую знак действия
            double First, Second;// вводим переменные обозначающие Первое и Второе число

            Console.WriteLine("\n" + MyName + ", программа Калькулятор может"
                 + " выполнять следующие команды:");
            Console.WriteLine(" -Plus - сложение; \n -Minus - вычитание; \n -Multiply - умножение; \n -Degree - деление.");
            Console.WriteLine("Какую кокоманды Вы хотите выполнить?");
            Cmd = Console.ReadLine();// позволяем пользователю выбрать действие
            Console.WriteLine("Введите первую переменную:");
            First = double.Parse(Console.ReadLine());// позволяем пользователю ввести Первую переменную
            Console.WriteLine("Введите вторую переменную:");
            Second = double.Parse(Console.ReadLine());// позволяем пользователю ввести Вотрую переменную 

            if (Cmd == "Plus")// если пользователь решил сложить переменные
            {
                Console.WriteLine("Итоговый результат: " + (First + Second));
            }
            else if (Cmd == "Minus")// если пользователь решил из Первой переменной вычесть Вторую
            {
                Console.WriteLine("Итоговый результат: " + (First - Second));
            }
            else if (Cmd == "Multiply")// если пользователь решил перемножить переменные
            {
                Console.WriteLine("Итоговый результат: " + (First * Second));
            }
            else if (Cmd == "Degree")// если пользователь решил разделить Первую переменную на Вторую
            {
                Console.WriteLine("Итоговый результат: " + (First / Second));
            }

            else // если пользователь тупой
            {
                Console.WriteLine("Команда не входит в список программы.");
            }
            Console.ReadKey();


        }
    }
}
