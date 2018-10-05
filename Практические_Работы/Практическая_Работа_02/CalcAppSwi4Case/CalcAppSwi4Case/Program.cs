using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAppSwi4Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ну кому я ТЕПЕРЬ нужен? мДаааа...Как низко ты пал. У тебя что нормального калькулятора нет? Ну ты даёшь...\nЛадно, чем раньше начнём, тем быстрее закончим. А чем быстрее закончим, тем лучше. Ок. Значит...\nКак мне к тебе обращаться?");
            string UserName = Console.ReadLine();
            Console.WriteLine("Ну что, " + UserName + ", Поехали...");
            Console.WriteLine("Я много чего могу: складывать(+), вычитать(-), делить(/), умножать(*)");
            Console.WriteLine("Вообщем всё, что хочешь. Ну что... Начнём?");

            double First, Second;
            Console.WriteLine("Итак, введи Первую переменную:");
            First = double.Parse(Console.ReadLine());
            if (First.GetTypeCode() == TypeCode.String) {
                Console.WriteLine("asasdasd");
            }
            Console.WriteLine("Введи Вторую переменную:");
            Second = double.Parse(Console.ReadLine());
            Console.WriteLine("Выбери математическое действие:");
            string Cmd = Console.ReadLine();
            switch (Cmd)
            {
                case "+":
                    Console.WriteLine("Ну и что у Тебя не получается? " + (First) + " + " + (Second) + " равно " + (First + Second) + ". Стыдно такие вещи не знать....");
                    break;
                case "-":
                    Console.WriteLine("Ну и что у Тебя не получается? " + (First) + " - " + (Second) + " равно " + (First - Second) + ". Стыдно такие вещи не знать....");
                    break;
                case "*":
                    Console.WriteLine("Ну и что у Тебя не получается? " + (First) + " * " + (Second) + " равно " + (First * Second) + ". Стыдно такие вещи не знать....");
                    break;
                case "/":
                    Console.WriteLine("Ну и что у Тебя не получается? " + (First) + " / " + (Second) + " равно " + (First / Second) + ". Стыдно такие вещи не знать....");
                    break;
                default:
                    Console.WriteLine("Я такого не умею. Иди поищи кого-нибудь другого...");
                    break;
            }


            Console.ReadKey();
        }
    }
}
