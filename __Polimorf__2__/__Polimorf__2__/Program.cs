// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Bus
    {
        public int _Number;
        public int _Passengers;
        public int _Consumption;
        public string? _How;
        public Bus(int num, int pas, int con)
        {
            _Number = num;
            _Passengers = pas;
            _Consumption = con;
        }
        override public string ToString()
        {
            return $"number {_Number}, passengers {_Passengers}, {_How} Consumption {_Consumption}";
        }
    }
    class TrolleyBus : Bus
    {
        public TrolleyBus(int num, int pas, int con):base(num, pas, con)
        {
            _How = "Electric";
        }
    }
  
    class AutoBus : Bus 
    {
        public AutoBus(int num, int pas, int con) : base(num, pas, con)
        {
            _How = "not Electric";
        }
    }
    class MicroBus : Bus
    {
        public MicroBus(int num, int pas, int con) : base(num, pas, con)
        {
            _How = "not Electric";
            if(pas <= 24)
            {
                _Passengers = pas;
            }
            else
            {
                Console.WriteLine(" ");
                _Passengers = 24;
            }
        }
    }
    internal class Program
    {
        static void Print(List<Bus> ts)
        {
            foreach (var item in ts)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TrolleyBus trolleyBus = new TrolleyBus(1,30,400);
            MicroBus microBus = new MicroBus(2, 30, 200);
            AutoBus autoBus = new AutoBus(3, 30, 300);

            List<Bus> depo = new List<Bus>();
            depo.Add(microBus);
            depo.Add(autoBus);
            depo.Add(trolleyBus);
            depo.Add(new MicroBus(4, 17, 180));
            depo.Add(new TrolleyBus(5, 40, 350));
            depo.Add(new AutoBus(6, 35, 200));


            Console.WriteLine("Press 1 to sort ||| press 2 to find amount ||| press 3 to find by number ||| press 4 to find by consumption ||| press 5 to print ||| press y for exit");
            while (true)
            {   
                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            depo.Sort(delegate (Bus x, Bus y)
                            {
                                if (x?._Passengers == null && y?._Passengers == null) return 0;
                                else if (x?._Passengers == null) return -1;
                                else if (y?._Passengers == null) return 1;
                                else return x._Passengers.CompareTo(y._Passengers);
                            });
                            break;
                        case 2:
                            int amount = depo.Count;
                            Console.WriteLine($"amount of buses {amount}");
                            break;
                        case 3:
                            Console.Write("enter number  ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            if (depo.Exists(b => b._Number == n))
                            {
                                Bus found = depo.Find(b => b._Number == n);
                                Console.WriteLine(found.ToString());
                            }
                            else
                            {
                                Console.WriteLine("nema takogo");
                            }
                            break;
                        case 4:
                            Console.Write("enter consuption  ");
                            int c = Convert.ToInt32(Console.ReadLine());
                            if (depo.Exists(b => b._Consumption == c))
                            {
                                Bus found2 = depo.Find(b => b._Consumption == c);
                                Console.WriteLine(found2.ToString());
                            }
                            else
                            {
                                Console.WriteLine("nema takogo");
                            }
                            break;
                        case 5:
                            Print(depo);
                            break;
                        default:
                            Console.WriteLine("Press 1 to sort ||| press 2 to find amount ||| press 3 to find by number ||| press 4 to find by consumption ||| press y for exit");
                            break;
                    }

                }
                catch
                {
                    Console.WriteLine("Press 1 to sort ||| press 2 to find amount ||| press 3 to find by number ||| press 4 to find by consumption ||| press y for exit");
                }
                if (Console.ReadKey(true).Key == ConsoleKey.Y)
                    break;
            };


        }
    }
}
