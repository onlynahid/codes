using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
     class Book : Product
       
    {
        
        public string genre {  get; set; }


        public Book(string genre,string name,int price,int count) : base(name,price,count)
        {

            this.genre = genre;

           }

 


  
    
    }




}
