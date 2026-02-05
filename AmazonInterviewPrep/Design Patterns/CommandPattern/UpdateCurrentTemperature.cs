using System;

namespace AmazonInterviewPrep.CommandPattern;

public class UpdateCurrentTemperature : ICommand
{
    private readonly Temperature temperature;
    public readonly string currentTemperature;

    public UpdateCurrentTemperature(Temperature temperature, string currentTemperature)
    {
        this.temperature = temperature;
        this.currentTemperature = currentTemperature;
    }

    public string Execute()
    {
        return $"updated temperature is {temperature.UpdateCurrentTemperature(currentTemperature)}";
    }
}
