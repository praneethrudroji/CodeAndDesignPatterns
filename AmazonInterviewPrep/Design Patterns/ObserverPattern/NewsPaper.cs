using System;

namespace AmazonInterviewPrep.ObserverPattern;

public class NewsPaper : ISubscriber
{
    public void Update(string context)
    {
        Console.WriteLine($"Newspaper: [{DateTime.Now}]: Latest news - {context}");
    }
}
