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
                Console.OutputEncoding = Encoding.UTF8;
                int Row = GetCountRows();
                int Column = GetStolbec();
                int[,] array = new int[Row, Column];
                array = InputArray(Row, Column);
                ShowArray(array);
                Console.ReadKey();
            }
            static int GetCountRows()
            {
                Console.Write("Amount of rows = ");
                return Convert.ToInt32(Console.ReadLine());
            }
            static int GetStolbec()
            {
                Console.Write("\nAmount of columns = ");
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
                        Console.Write("Type in number ->  ");
                        array[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                return array;
            }
            static void ShowArray(int[,] array)
            {
                Console.WriteLine("\n" +
                "Result");
           
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                   
                        Console.Write("{0}\t", array[i, j]);
                    }
                Console.WriteLine();
                }
              
              Console.WriteLine("");
            }
    }
}
