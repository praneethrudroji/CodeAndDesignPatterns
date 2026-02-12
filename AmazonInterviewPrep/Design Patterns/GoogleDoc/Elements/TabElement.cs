using System;
using System.Text;

namespace AmazonInterviewPrep.Design_Patterns.GoogleDoc;

public class TabElement : IDocumentElement
{
    public string RenderElement()
    {
        return "\t";
    }
}
