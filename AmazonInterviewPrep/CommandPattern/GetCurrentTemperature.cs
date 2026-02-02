using System;

namespace AmazonInterviewPrep.CommandPattern;

public class GetCurrentTemperature : ICommand
{
    private Temperature temperature;

    public GetCurrentTemperature(Temperature temperature)
    {
        this.temperature = temperature;
    }

    public string Execute()
    {
        return $"current temperature is {temperature.GetCurrentTemperature()}";
    }
}
