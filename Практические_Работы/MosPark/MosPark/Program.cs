using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosPark
{

   class Car
    {
        public string Brand;
        public string Model;
        public string Colour;
        public float Number;
        DateTime ArivalTime = DateTime.Now;

        public void GetInfo()
        {
            Console.WriteLine($"Brand: {Brand} \nModel: {Model} \nColour: {Colour} \nNumber: {Number}\nTime of arival: {ArivalTime} ");
        }
    }
    class Parking
    {
        public float ParkingPlace; //место парковки 
        public float DataTime; //время прибытия 


    }
    class Program
    {
        static void Main(string[] args)
        {
            Car info = new Car();
            Console.WriteLine("Type your Brand: ");
            info.Brand = Console.ReadLine();
            Console.WriteLine("Type your Model: ");
            info.Model = Console.ReadLine();
            Console.WriteLine("Type your Colour: ");
            info.Colour = Console.ReadLine();
            Console.WriteLine("Type your Number: ");
            info.Number = Convert.ToInt32(Console.ReadLine());
            info.GetInfo();
            Console.ReadKey();

        }

}
