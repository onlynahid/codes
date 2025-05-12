using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Car : Vehicle
    {
        public string brand;
        public string model;
        public int fuelcapacity;
        public int fuelfor1km;
        public int currentfuel;
        public Car()
        {
            
        }

        //public Car()
        //{

        //}
        public Car(string brand, string model, int fuelcapacity, int fuelfor1km, int currentfuel) : base(2014,"red")
        {
            this.brand = brand;
            this.model = model;
            this.fuelcapacity = fuelcapacity;
            this.fuelfor1km = fuelfor1km;
            this.currentfuel = currentfuel;


        }

        public void Showinfo(int year, string color, string brand, string model, int fuelcapacity, int fuelfor1km, int currentfuel)
        {
            Console.WriteLine($"brand : {brand} model : {model} fuelcapacity : {fuelcapacity} fuelfor1km : {fuelfor1km} currentfuel {currentfuel}");

            Console.WriteLine($" Year : {year}, Color : {color}");
        }

        public void Drive(int km)
        {

            int nededed = km * fuelfor1km;

            if (currentfuel >= nededed)
            {
                currentfuel -= nededed;
                Console.WriteLine($"Masin {km} km getdi.qalan benzin {currentfuel}");

            }
            else
            {
                Console.WriteLine("azdir");
            }

        }
    }
}

