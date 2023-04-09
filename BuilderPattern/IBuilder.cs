using System;

public interface IBuilder
{
    void Reset();
    void SetSeats(uint seats);
    void SetEngine(string engine);
    void SetTripComputer(bool tripComputer);
    void SetGPS(bool gps);
}
