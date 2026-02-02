using System;

namespace AmazonInterviewPrep.Chain_of_Responsibility;

public class SanitizeHandler : BaseHandler
{
    public override object? Handle(string request)
    {
        Console.WriteLine($"[SanitizeHandler]: {request} is processed");
        return base.Handle(request);
    }
}
