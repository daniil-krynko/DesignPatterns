using System;

public class WinButton : IButton
{
	public WinButton()
	{ }
	public void Paint()
	{ Console.WriteLine("Drawing Windows button"); }
}

public class WinCheckbox : ICheckbox
{
	public WinCheckbox() 
	{ }
	public void Paint() 
	{ Console.WriteLine("Drawing Windows checkbox"); }
}