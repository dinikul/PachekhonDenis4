using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLaba4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "";
            int distance = 0;
            int price;
            int time;
            Plane plane = new Plane(500, 3);
            Train train = new Train(200, 1);
            Car car = new Car(120, 2);
            Vagon vagon = new Vagon(100, 1);
            Console.WriteLine("Ваше мiсце знахоження Київ");
            Console.WriteLine("Щоб продовжити виберiть, або ввести назву мiста(тiльки для Львова, Одеси, Москви), або ввести вiдстань перевезення. Для цього напишiть 'city', або 'distance'");
            string x = Console.ReadLine();
            Console.Clear();
            if(x == "city")
            {
                Console.Write("Назва мiста: ");
                city = Console.ReadLine();
            }
            if (x == "distance")
            {
                Console.Write("Вiдтань: ");
                distance = Convert.ToInt32(Console.ReadLine());
            }
            if(city == "Lviv")
            {
                distance = 464;
            }
            if (city == "Odessa")
            {
                distance = 472;
            }
            if (city == "Moscow")
            {
                distance = 857;
            }
            Console.Clear();
            Console.Write("Bиберiть транспорт(Наприклад, щоб вибрати лiтак, потрiбно ввести 'plane'): ");
            string cargo_carrier = Console.ReadLine();
            Console.Clear();
            if(cargo_carrier == "plane")
            {
                Console.WriteLine("Ви вибрали лiтак");
                price = 3 * distance;
                time = distance / 500;
                Console.WriteLine("До сплати: " + price);
                Console.WriteLine("Час перевезення: " + time);
            }
            if (cargo_carrier == "train")
            {
                Console.WriteLine("Ви вибрали поїзд");
                price =  1* distance;
                time = distance / 200;
                Console.WriteLine("До сплати: " + price);
                Console.WriteLine("Час перевезення: " + time);
            }
            if (cargo_carrier == "car")
            {
                Console.WriteLine("Ви вибрали автомобiль");
                price = 2 * distance;
                time = distance / 120;
                Console.WriteLine("До сплати: " + price);
                Console.WriteLine("Час перевезення: " + time);
            }
            if (cargo_carrier == "vagon")
            {
                Console.WriteLine("Ви вибрали вагон");
                price = 1 * distance;
                time = distance / 100;
                Console.WriteLine("До сплати: " + price);
                Console.WriteLine("Час перевезення: " + time);
            }

        }
    }
    abstract class Cargo_carrier
    {
        public int Speed;
        public int Price_of_1_km;
        public Cargo_carrier(int speed, int price)
        {
            Speed = speed;
            Price_of_1_km = price;
        }
    }
    class Plane : Cargo_carrier
    {
        public Plane(int speed, int price) : base(speed, price)
        {

        }
        public void Route()
        {
            
        }
    }
    class Train : Cargo_carrier
    {
        public Train(int speed, int price) : base(speed, price)
        {

        }
    }
    class Car : Cargo_carrier
    {
        public Car(int speed, int price) : base(speed, price)
        {

        }
    }
    class Vagon : Cargo_carrier
    {
        public Vagon(int speed, int price) : base(speed, price)
        {

        }
    }

}
