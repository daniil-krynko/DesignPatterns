using System;

public class Car
{
    uint _seats = 1;
    string _engine;
    bool _tripComputer = false;
    bool _gps = false;
    bool _hidingUp = false;

    public Car()
	{

	}

    public void SetSeats(uint seats)
    { _seats = seats; }

    public void SetEngine(string engine)
    { _engine = engine; }

    public void SetComputer(bool tripComputer)
    { _tripComputer = tripComputer; }

    public void SetGPS(bool gps)
    { _gps = gps; }

    public void SetHidingUp(bool hidingUp)
    { _hidingUp = hidingUp; }

    public void Info()
    {
        Console.WriteLine($"Seats-{_seats}; Eng-{_engine}; Trip computer is available-{_tripComputer}; GPS is enabled-{_gps}; Cabriolet is-{_hidingUp}");
    }
}
