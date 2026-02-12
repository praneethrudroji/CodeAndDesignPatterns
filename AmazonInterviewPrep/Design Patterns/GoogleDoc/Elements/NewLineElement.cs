using System;

namespace AmazonInterviewPrep.Design_Patterns.GoogleDoc;

public class NewLineElement : IDocumentElement
{
    public string RenderElement()
    {
        return "\n";
    }
}
