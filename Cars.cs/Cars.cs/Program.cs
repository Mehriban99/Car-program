using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Car masin1 = new Car("Lexus","ES350");
            string userInput;
            do
            {
                Console.WriteLine("1.Go");
                Console.WriteLine("2.Top up");
                Console.WriteLine("3.Local km");
                Console.WriteLine("4.Global km");
                Console.WriteLine("5.Exit");
                Console.Write(">>>>>>>>");
                userInput = Console.ReadLine();
                if(CheckInput(userInput))
                {
                    switch(userInput)
                    {
                        case "1":
                            masin1.Go();
                            break;
                        case "2":
                            masin1.Fuel();
                            break;
                        case "3":
                            Console.WriteLine("Local km bu qederdir");
                            break;
                        case "4":
                            Console.WriteLine("Qlobal km bu qederdir");
                            break;
                        default:
                            Console.WriteLine("Xahis edirik yuxaridakilardan birini yazin");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Xahis edirik yuxaridaki reqemlerden birini daxil edin");
                }

            } while (userInput != "5");
        }
        static bool CheckInput(string input)
        {
            try
            {
                int userInput = Convert.ToInt32(input);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    class Car
    {
        public string Model;
        public string Marka;
        private int FullEff;
        private int CurrentEff;
        private int MaxFuel;
        int neededKM = 0;
        public Car(string marka, string model,int fullEff=13,int currentEff = 30,int maxFuel=60)
        {
            Marka = marka;
            Model = model;
            FullEff = fullEff;
            CurrentEff = currentEff;
            MaxFuel = maxFuel;
        }
        public void Go()
        {
            int neededKM = 0;
            while(neededKM==0)
            {
                Console.Write("Nece km getmek isteyirsiniz? :");
                string input = Console.ReadLine();
                if (CheckInput(input))
                {
                    neededKM = Convert.ToInt32(input);
                    if(MaxFuel <= neededKM / 100 * FullEff)
                    {
                        Console.WriteLine("Sizin kifayet qeder benzininiz yoxdur, benzin vurun");
                    }
                    else
                    {
                        CurrentEff -= neededKM / 100 * FullEff;
                        Console.WriteLine("Siz {0} km getseniz {1} litr benzin qalacaq",neededKM,CurrentEff);
                    }
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa musbet reqem daxil edin");
                }
            }
            
        }
        static bool CheckInput(string input)
        {
            try
            {
                int neededKm = (int)Convert.ToUInt32(input);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Fuel()
        {

        }
    }
    
}
