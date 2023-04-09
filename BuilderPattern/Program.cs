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
            Car sportCar = builder.GetProduct();
            Console.WriteLine("SPORT CAR");
            sportCar.Info();
            Console.WriteLine();

            director.ConstructSUVCar(builder);
            Car suvCar = builder.GetProduct();
            Console.WriteLine("SUV CAR");
            suvCar.Info();
            Console.WriteLine();
        }
    }
}