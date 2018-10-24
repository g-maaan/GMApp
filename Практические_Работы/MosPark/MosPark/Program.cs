using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosPark
{

    class Automobile
    {
        public string Marka = Console.ReadLine();
        public string Model = Console.ReadLine();
        public string color = Console.ReadLine();

    }
    class Parking
    {
        public int Number = int.Parse(Console.ReadLine());
        public DateTime currentDate = DateTime.Now;
    }




    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);

            Console.WriteLine(Marka);
            Console.ReadKey();





        }
    }
}
