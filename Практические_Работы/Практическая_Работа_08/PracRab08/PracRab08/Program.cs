using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracRab08
{
    class Program
    {
        static void Main(string[] args)
        {
           
            static void Main(string[] args)
            {
            Console.OutputEncoding = Encoding.UTF8;
            int stroka = GetCountRows();
                int stolbec = GetStolbec();

                int[,] array = new int[stroka, stolbec];

                array = InputArray(stroka, stolbec);
                ShowArray(array);

                Console.ReadKey();
            }

            static int GetCountRows()
            {
                Console.Write("Количество строк = ");
                return Convert.ToInt32(Console.ReadLine());
            }

            static int GetStolbec()
            {
                Console.Write("\nКоличество столбцов = ");
                return Convert.ToInt32(Console.ReadLine());
            }

            static int[,] InputArray(int stroka, int stolbec)
            {
                int[,] array = new int[stroka, stolbec];
                Console.WriteLine();
                for (int i = 0; i < stroka; i++)
                {
                    for (int j = 0; j < stolbec; j++)
                    {
                        Console.Write("Введите число ->  ");
                        array[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
               }

                return array;
            }

            static void ShowArray(int[,] array)
            {
                Console.WriteLine("\n" +
                    "А вот и твой массивчик");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", array[i, j]);
                    }
                    Console.WriteLine();

                }
            }
        }
    }
}
