using System;

namespace AmazonInterviewPrep.ObserverPattern;

public interface ISubscriber
{
    void Update(string context);
}
