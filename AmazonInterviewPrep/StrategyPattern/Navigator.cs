using System;
using AmazonInterviewPrep.StrategyPattern;

namespace AmazonInterviewPrep.ObserverPattern;

public class Navigator : INavigator
{
    private IRouteStrategy routeStrategy;

    public Navigator(IRouteStrategy routeStrategy)
    {
        this.routeStrategy = routeStrategy;
    }
    public void DisplayRoute(decimal longitude, decimal latitude)
    {
        var coordinates = routeStrategy.buildRoute(longitude, latitude);
        System.Console.WriteLine($"{routeStrategy.Name}: Route co-ordinates {string.Join("->", coordinates)}");
    }

    public void SetStrategy(IRouteStrategy routeStrategy)
    {
        this.routeStrategy = routeStrategy;
    }
}
