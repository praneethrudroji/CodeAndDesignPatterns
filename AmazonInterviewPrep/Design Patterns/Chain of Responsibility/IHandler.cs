using System;

namespace AmazonInterviewPrep.Chain_of_Responsibility;

public interface IHandler
{
    IHandler SetNext(IHandler handler);
    object? Handle(string request);
}
