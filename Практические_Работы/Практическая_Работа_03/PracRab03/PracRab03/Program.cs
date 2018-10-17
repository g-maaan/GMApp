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
             Console.WriteLine("Здравствуйте, вас приветствует программа 'Анкета'. \nГрише не хватило времени сделать мне дружелюбный интерфейс.\nПоэтому, давай по делу:");
            Console.WriteLine("Имя: ");
            string Name = (Console.ReadLine());// пользователь вводит имя
            Console.WriteLine("Фамилия: ");
            string Surname = (Console.ReadLine());// пользователь вводит отчество
            Console.WriteLine("Отчество: ");
            string LName = (Console.ReadLine());// пользователь вводит фамилию
            Console.WriteLine("Возраст: ");
            float Years = float.Parse(Console.ReadLine());// пользователь вводит свой возраст
            
            Console.WriteLine("Место учёбы: ");
            string PlaceOfStudy = (Console.ReadLine());// пользователь вводит место учёбы
            Console.WriteLine(" Группа: ");
            string Group = (Console.ReadLine());// пользователь вводит свою группу
            Console.WriteLine("Пол: М или Ж ");
            string Gender = (Console.ReadLine());// пользователь вводит свой пол
            
            switch (Gender)
            {


                case ("М"):// если пользователь - мужик, то всё работает
                    Console.WriteLine(" \n***********************************\n*     * АНКЕТА ПОЛЬЗОВАТЕЛЯ *     *" + "\n***********************************\n*ФИО: " + Surname + " " + Name + " " + LName + "         *\n*Возраст: " + Years +
            "         *\n*Пол: " + Gender + "         *\n*Место учёбы: " + PlaceOfStudy + "         *\n*Группа: " + Group + "        *\n                                  *\n***********************************");


                    break;
                case ("Ж"):// и если пользователь - женщина, тоже всё работает
                    Console.WriteLine(" \n***********************************\n*     * АНКЕТА ПОЛЬЗОВАТЕЛЯ *     *" + "\n***********************************\n*ФИО: " + Surname + " " + Name + " " + LName + "         *\n*Возраст: " + Years +
            "         *\n*Пол: " + Gender + "         *\n*Место учёбы: " + PlaceOfStudy + "         *\n*Группа: " + Group + "        *\n                                  *\n***********************************");


                    break;
                default:// без комментариев
                    Console.WriteLine("Я конечно толлерантный и все дела, но это перебор...\nПока...");
                    break;
            }
           

            Console.ReadKey();
        }
    }
}
