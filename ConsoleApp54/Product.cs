namespace ConsoleApp54
{
    class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public int count;
        public int percentageofdiscount;
        public Product()
        {
            
        }

        public Product(string name, int price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;



        }

        public string Detail()
        {
            return $" Name : {name}, Price {price}, Count : {count}";
            

        }

        public int Discount( int percentageofdiscount)
        {

            return price - (price * percentageofdiscount / 100);
        
        }

   
    
    
    
    }

}
