using System;

namespace AmazonInterviewPrep.CommandPattern;

/*
    Button class which is responsible to invoke Get current temperature in a city or update temperature
*/
public class Button
{
    private readonly ICommand command;

    public Button(ICommand command)
    {
        this.command = command;
    }

    public object OnClick()
    {
        return command.Execute();
    }

}
