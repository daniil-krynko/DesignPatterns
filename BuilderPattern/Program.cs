using System.ComponentModel.DataAnnotations;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of Builder pattern\n");

            Director director = new Director();

            CarBuilder builder = new CarBuilder();
            director.ConstructSportCar(builder);
            Car car = builder.GetProduct();
        }
    }
}