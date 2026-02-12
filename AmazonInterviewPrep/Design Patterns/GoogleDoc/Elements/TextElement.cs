using System;
using System.Text;

namespace AmazonInterviewPrep.Design_Patterns.GoogleDoc;

public class TextElement(string text) : IDocumentElement
{
    private readonly string text = text;

    public string RenderElement()
    {
        return text;
    }
}
