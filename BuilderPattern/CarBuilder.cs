using System;

public class CarBuilder : IBuilder
{
	Car _car = new Car();

    public CarBuilder()
	{
		this.Reset();
	}

	public void Reset()
	{ _car = new Car(); }

    public void SetSeats(uint seats)
	{ _car.SetSeats(seats); }

    public void SetEngine(string engine)
	{ _car.SetEngine(engine); }

    public void SetTripComputer(bool computer)
	{ _car.SetComputer(computer); }

    public void SetGPS(bool gps)
	{ _car.SetGPS(gps); }

    public Car GetProduct()
	{
		Car product = _car;
		this.Reset();
		return product;
	}
}
