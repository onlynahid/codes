using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Rectangle : Shape
    {
 public int Length;

        
        public Rectangle(int Length)
        {

            this.Length = Length;
        }
       
        public int CalculateArea()
        {
            return Length * Length;
       
        
        
        }
        
        
        



    }

   




}
