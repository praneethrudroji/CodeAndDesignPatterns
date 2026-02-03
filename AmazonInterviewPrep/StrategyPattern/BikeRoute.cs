using System;

namespace AmazonInterviewPrep.StrategyPattern;

public class BikeRoute : IRouteStrategy
{
    public string Name => "[Bike Route]";

    public double[] buildRoute(decimal longitude, decimal latitude)
    {
        var random = new Random();
        double[] coordinates = new double[5];
        for(int i=0; i<5; i++)
        {
            coordinates[i] = random.NextDouble();
        }
        return coordinates;
    }
}
