namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello, World!");
            Account account = new Account();
            int password = Convert.ToInt32(Console.ReadLine());
            string username = Console.ReadLine();
            account.Login(username, password);
            Vehicle vehicle = new Vehicle();
            Car car = new Car();
            car.Showinfo(2014, "red", "bmw", "m5 ", 100, 2, 40);
            car.Drive(15);
            Rectangle rectangle = new Rectangle(4);
         Console.WriteLine(rectangle.CalculateArea());
            Shape shape = new Shape();
            shape.Getinfo("red");
            
            


        }
    }
}



