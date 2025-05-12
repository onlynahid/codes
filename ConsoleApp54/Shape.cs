using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Shape
    {
        public string color;
        public string area;
        public Shape()
        {

        }

        public Shape(string color)
        {
            this.color = color;


        }

        public void Getinfo(string color)
        {

            Console.WriteLine("color" + color);
            Console.WriteLine("area" + area);



        }
    }

}
