using System;

public class GUI
{
	IGUIFactory factory;
	IButton button;
	ICheckbox checkbox;
	public GUI(IGUIFactory factory)
	{
		this.factory = factory;
	}
	public void CreateUI()
	{
		this.button = factory.CreateButton();
		this.checkbox = factory.CreateCheckbox();
	}
	public void Paint()
	{
		this.button.Paint();
		this.checkbox.Paint();
	}
}
