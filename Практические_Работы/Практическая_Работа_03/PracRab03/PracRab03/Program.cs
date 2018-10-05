using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracRab03
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Здравствуйте, вас приветствует программа анкета. \nГрише не хватило времени сделать мне дружелюбный интерфейс.\nПоэтому, давай по делу:");
            Console.WriteLine("Имя: ");
            string Name = (Console.ReadLine());
            Console.WriteLine("Фамилия: ");
            string Surname = (Console.ReadLine());
            Console.WriteLine("Отчество: ");
            string LName = (Console.ReadLine());
            Console.WriteLine("Возраст: ");
            float Years = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Место учёбы: ");
            string PlaceOfStudy = (Console.ReadLine());
            Console.WriteLine(" Группа: ");
            string Group = (Console.ReadLine());
            Console.WriteLine("Пол: М или Ж ");
            string Gender = (Console.ReadLine());
            
            switch (Gender)
            {


                case ("М"):
                    Console.WriteLine(" \n***********************************\n*     * АНКЕТА ПОЛЬЗОВАТЕЛЯ *     *" + "\n***********************************\n*ФИО: " + Surname + " " + Name + " " + LName + "         *\n*Возраст: " + Years +
            "         *\n*Пол: " + Gender + "         *\n*Место учёбы: " + PlaceOfStudy + "         *\n*Группа: " + Group + "        *\n                                  *\n***********************************");


                    break;
                case ("Ж"):
                    Console.WriteLine(" \n***********************************\n*     * АНКЕТА ПОЛЬЗОВАТЕЛЯ *     *" + "\n***********************************\n*ФИО: " + Surname + " " + Name + " " + LName + "         *\n*Возраст: " + Years +
            "         *\n*Пол: " + Gender + "         *\n*Место учёбы: " + PlaceOfStudy + "         *\n*Группа: " + Group + "        *\n                                  *\n***********************************");


                    break;
                default:
                    Console.WriteLine("Я конечно толлерантный и все дела, но это перебор...\nПока...");
                    break;
            }
           

            Console.ReadKey();
        }
    }
}
