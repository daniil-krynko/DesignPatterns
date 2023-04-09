using System;

public class MacButton : IButton
{
	public MacButton()
	{ }
	public void Paint()
	{ Console.WriteLine("Drawing Mac button"); }
}

public class MacCheckbox : ICheckbox
{
    public MacCheckbox()
    { }
    public void Paint()
    { Console.WriteLine("Drawing Mac checkbox"); }
}