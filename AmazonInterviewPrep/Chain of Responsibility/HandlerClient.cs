using System;

namespace AmazonInterviewPrep.Chain_of_Responsibility;

public class HandlerClient
{
    public void Handle()
    {
        IHandler authHandler = new AuthHandler();
        IHandler santizeHandler = new SanitizeHandler();

        authHandler.SetNext(santizeHandler);
        authHandler.Handle("My request");
    }
}
