using System;

namespace AmazonInterviewPrep.Chain_of_Responsibility;

public class HandlerClient
{
    public void Handle()
    {
        IHandler authHandler = new AuthHandler();
        IHandler sanitizeHandler = new SanitizeHandler();

        authHandler.SetNext(sanitizeHandler);
        authHandler.Handle("My request");
    }
}
