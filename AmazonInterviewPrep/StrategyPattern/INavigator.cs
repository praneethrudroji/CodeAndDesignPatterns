using System;

namespace AmazonInterviewPrep.StrategyPattern;

public interface INavigator
{
    void SetStrategy(IRouteStrategy routeStrategy);
    void DisplayRoute(decimal longitude, decimal latitude);
}
