using System;

//declaring the event handler delegate
delegate void ButtonEventHandler(object source, int clickCount);

class Button
{
    //declaring the event
    public event ButtonEventHandler ButtonClick;

    //Function to trigger the event
    public void clicked(int count)
    {
        Console.WriteLine("\nInside Clicked !!!");
        //Invoking all the event handlers
        if (ButtonClick != null) ButtonClick(this, count);
    }
}
public class Dialog
{
    public Dialog()
    {
        Button b = new Button();

        //Adding an event handler
        b.ButtonClick += new ButtonEventHandler(onButtonAction);
        //Triggering the event
        b.clicked(1);

        b.ButtonClick += new ButtonEventHandler(onButtonAction);
        b.clicked(1);

        //Removing an event handler
        b.ButtonClick -= new ButtonEventHandler(onButtonAction);
        b.clicked(1);

        b.ButtonClick -= new ButtonEventHandler(onButtonAction);
        b.clicked(1);
    }
    static void Main()
    {
        new Dialog();
    }

    //Event Handler function
    public void onButtonAction(object source, int clickCount)
    {
        Console.WriteLine("Inside Event Handler !!!");
       Console.ReadLine();
    }
}

