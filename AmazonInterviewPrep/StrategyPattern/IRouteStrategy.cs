using System;

namespace AmazonInterviewPrep.StrategyPattern;

/*
    The main purpose of Strategy pattern is to build different algorithms to achieve one thing. 
    Strategy is a behavioral design pattern that lets you define a family of algorithms, 
    put each of them into a separate class, and make their objects interchangeable.
*/
public interface IRouteStrategy
{
    string Name {get;}
    double[] buildRoute(decimal longitude, decimal latitude);
}
