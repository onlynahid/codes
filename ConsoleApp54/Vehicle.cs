namespace ConsoleApp54
{
    class Vehicle
    {
       public string color;
       public int year;
      public  string brand;
       public  string model;
       public int fuelcapacity;
       public  int fuelfor1km;
        public  int currentfuel;
        public Vehicle()
        {
            
        }
        public Vehicle(string brand, string model, int fuelcapacity, int fuelfor1km, int currentfuel)
        {
            brand = brand;
            model = model;
            fuelcapacity = fuelcapacity;
            fuelfor1km = fuelfor1km;
            currentfuel = currentfuel;
        
        
        }
        public Vehicle( int year, string color )
        {
          this.color = color;
           this.year = year;
        }


    }
}



