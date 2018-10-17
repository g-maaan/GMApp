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
            Random rnd = new Random();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int[,] numbers = new int[x, y];
            {

                for (; ; x++)
                {
                    for (; ; y++)
                    {
                        numbers[x, y] = rnd.Next(-1000, 1000);
                        Console.Write("({1}) -> {0}\t", numbers[x, y]);
                    }
                    Console.WriteLine();
                }
            
            Console.ReadKey();
        }
    }
}
