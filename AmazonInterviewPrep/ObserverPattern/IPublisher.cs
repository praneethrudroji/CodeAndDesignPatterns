using System;

namespace AmazonInterviewPrep.ObserverPattern;

public interface IPublisher
{
    void ModifyState(string news);
    void Subscribe(ISubscriber subscriber);
    void Unsubscribe(ISubscriber subscriber);
    void NotifySubscribers(string context);
}
