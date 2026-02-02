using System;
using System.Collections.Concurrent;

namespace AmazonInterviewPrep.ObserverPattern;

public class Publisher : IPublisher
{
    List<ISubscriber> subscribers = [];
    private string news;
    public Publisher()
    {
        news = string.Empty;
    }

    public void ModifyState(string news)
    {
        this.news = news;
        NotifySubscribers(news);
    }

    public void NotifySubscribers(string context)
    {
        foreach(var subscriber in subscribers)
        {
            subscriber.Update(context);
        }
    }

    public void Subscribe(ISubscriber subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        if(subscribers.Count == 0) throw new Exception("No subscribers exists");
        subscribers.Remove(subscriber);
    }
}
