using System;

namespace AmazonInterviewPrep.Chain_of_Responsibility;

public class BaseHandler : IHandler
{
    private IHandler? _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual object? Handle(string request)
    {
        return _nextHandler?.Handle(request);
    }
}
