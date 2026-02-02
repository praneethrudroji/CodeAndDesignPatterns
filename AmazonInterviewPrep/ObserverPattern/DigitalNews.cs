using System;

namespace AmazonInterviewPrep.ObserverPattern;

public class DigitalNews : ISubscriber
{
    public void Update(string context)
    {
        Console.WriteLine($"Digital: [{DateTime.Now}]: Latest news - {context}");
    }
}
