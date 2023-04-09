using System;

public class Director
{
    public Director()
    {

    }
    public void ConstructSportCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(2);
        builder.SetEngine("twin-turbocharged Tipo F120A");
        builder.SetTripComputer(true);
        builder.SetGPS(true);
    }
    public void ConstructSUVCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(5);
        builder.SetEngine("Chrysler Pentastar");
        builder.SetGPS(true);
    }
}
