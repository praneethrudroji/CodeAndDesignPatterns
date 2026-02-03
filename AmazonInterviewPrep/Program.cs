using AmazonInterviewPrep.Chain_of_Responsibility;
using AmazonInterviewPrep.CommandPattern;
using AmazonInterviewPrep.ObserverPattern;
using AmazonInterviewPrep.StrategyPattern;
using AmazonInterviewPrep.TicTacToe;

namespace AmazonInterviewPrep;

class Program
{
    static void Main(string[] args)
    {
        StrategyPattern();
    }

    private static void StrategyPattern()
    {
        IRouteStrategy car = new CarRoute();
        IRouteStrategy bike = new BikeRoute();
        IRouteStrategy walk = new WalkRoute();

        Navigator navigator = new(walk);
        navigator.DisplayRoute(5, 5);

        navigator.SetStrategy(bike);
        navigator.DisplayRoute(7, 9);

        navigator.SetStrategy(car);
        navigator.DisplayRoute(9, 11);
    }

    private static void CommandPattern()
    {
        GUI_Interface GUI_Interface = new();
        GUI_Interface.InitializeGUI();
    }

    private static void ChainResponsibility()
    {
        HandlerClient handlerClient = new();
        handlerClient.Handle();
    }

    private static void PubSub()
    {
        ISubscriber newsPaper = new NewsPaper();
        ISubscriber digitalPaper = new DigitalNews();

        Publisher publisher = new Publisher();
        publisher.Subscribe(newsPaper);
        publisher.ModifyState("There is heavy rainfall here!!");

        publisher.Subscribe(digitalPaper);
        publisher.ModifyState("1 There is heavy rainfall here!!");
        publisher.ModifyState("2 There is heavy rainfall here!!");
        publisher.ModifyState("3 There is heavy rainfall here!!");
        publisher.ModifyState("4 There is heavy water here!!");

        publisher.Unsubscribe(digitalPaper);
        publisher.ModifyState("There is heavy fire here!!");
    }
}
