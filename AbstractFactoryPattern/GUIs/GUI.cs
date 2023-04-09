using System;

public class GUI
{
	IGUIFactory factory;
	IButton button;
	public GUI(IGUIFactory factory)
	{
		this.factory = factory;
	}
	public void CreateUI()
	{ this.button = factory.CreateButton(); }
	public void Paint()
	{ this.button.Paint(); }
}
