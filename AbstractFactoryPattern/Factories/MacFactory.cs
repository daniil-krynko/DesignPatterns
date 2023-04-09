using System;

public class MacFactory : IGUIFactory
{
	public MacFactory()
	{ }
    public IButton CreateButton()
    {
        Console.WriteLine("Creating Mac button");
        return new MacButton();
    }
    public ICheckbox CreateCheckbox()
    {
        Console.WriteLine("Creating Mac checkbox");
        return new MacCheckbox();
    }
}
