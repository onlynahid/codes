using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Product product = new Product();
            Console.WriteLine(product.Detail());
            Console.WriteLine(product.Discount(20));
            Book book = new Book("genre1", "alma", 100, 20);
            
        }

    }

}
