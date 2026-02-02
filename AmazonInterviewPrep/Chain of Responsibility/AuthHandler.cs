using System;

namespace AmazonInterviewPrep.Chain_of_Responsibility;

public class AuthHandler : BaseHandler
{
    public override object? Handle(string request)
    {
        Console.WriteLine($"[AuthHandler]: Processing request in auth handler");
        return base.Handle(request);
    }
}
