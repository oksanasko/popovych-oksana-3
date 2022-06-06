// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Plane
    {

        class Wings
        {
            public void Check()
            {
                Console.WriteLine("The wings are checked");
            }
        }
        class Chassis
        {
            public void Hide()
            {
                Console.WriteLine("The chassis is hidden");
            }
        }
        class Engines
        {
            public void Start()
            {
                Console.WriteLine("The engines are running");
            }
        }
        public void Fly()
        {
            Engines engines = new Engines();
            engines.Start();
            Wings wings = new Wings();
            wings.Check();
            Chassis chassis = new Chassis();
            chassis.Hide();
            Console.WriteLine("The plane took off");
        }
        public void SetTheRoute()
        {
            Console.Write("the distance in km is ");
            _distance = Convert.ToInt32(Console.ReadLine());
            Console.Write("The plane flies from ");
            _from = Console.ReadLine();
            Console.Write("to the ");
            _to = Console.ReadLine();
            _time = _distance / 800;
            if (_distance == 0 || _time == 0 || _from == null || _to == null)
            {
                Console.WriteLine("There is no route");
            }
            else
            {
                Console.WriteLine("The route is set");
            }
        }
        public void PrintTheRoute()
        {
            if (_distance == 0 || _time == 0 || _from == null || _to == null)
            {
                Console.WriteLine("There is no route");
            }
            else
            {
                Console.WriteLine($"The distance from {_from} to {_to} is {_distance} km. It will take more than {_time} hours");
            }
        }
        private int? _distance;
        private string _from;  
        private string _to; 
        private float? _time;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Plane plane = new Plane();
            while (true)
            {
                Console.WriteLine("Press 1 to fly ||| press 2 to set the route ||| press 3 to print the route ||| press y for exit");
                try 
                { 
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            plane.Fly();
                            break;
                        case 2:
                            plane.SetTheRoute();
                            break;
                        case 3:
                            plane.PrintTheRoute();
                            break;
                        default:
                            Console.WriteLine("Press 1 to fly ||| press 2 to set the route ||| press 3 to print the route ||| press y for exit");
                            break;
                    } 
                
                }
                catch
                {
                    Console.WriteLine("Press 1 to fly ||| press 2 to set the route ||| press 3 to print the route ||| press y for exit");
                }
                //plane.Fly();
                //plane.SetTheRoute();
                //plane.PrintTheRoute();
                //Console.ReadKey();
                if (Console.ReadKey(true).Key == ConsoleKey.Y)
                    break;
            };

        }
    }
}
