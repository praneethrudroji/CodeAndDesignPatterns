using System;

namespace AmazonInterviewPrep.CommandPattern;

public class Temperature
{
    private string temperature;
    public Temperature()
    {
        temperature = "15";
    }

    public string GetCurrentTemperature()
    {
        return temperature;
    }

    public string UpdateCurrentTemperature(string current_temp)
    {
        return temperature = current_temp;
    }
}
