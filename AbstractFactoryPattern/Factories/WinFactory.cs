using System;

public class WinFactory : IGUIFactory
{
	public WinFactory()
	{ }
	public IButton CreateButton()
	{
        Console.WriteLine("Creating Windows button");
        return new WinButton();
	}
	public ICheckbox CreateCheckbox()
	{
        Console.WriteLine("Creating Windows checkbox");
        return new WinCheckbox();
	}
}
