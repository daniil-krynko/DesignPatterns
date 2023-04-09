using System;

public class CarBuilder : IBuilder
{
	Car car;
	uint seats;
	string engine;
	bool tripComputer;
	bool gps;

    public CarBuilder()
	{
		this.Reset();
	}
	public void Reset()
	{ this.car = new Car(); }
    public void SetSeats(uint count)
	{ seats = count; }
    public void SetEngine(string engine)
	{ this.engine = engine; }
    public void SetTripComputer(bool computer)
	{ tripComputer = computer; }
    public void SetGPS(bool gps)
	{ this.gps = gps; }
    public Car GetProduct()
	{
		Car product = this.car;
		this.Reset();
		return product;
	}
}
