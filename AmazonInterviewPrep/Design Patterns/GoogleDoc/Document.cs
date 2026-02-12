using System;
using System.Text;

namespace AmazonInterviewPrep.Design_Patterns.GoogleDoc;

public class Document
{
    readonly List<IDocumentElement> documentElements = [];

    public void AddElement(IDocumentElement element)
    {
        documentElements.Add(element);
    }

    public string Render()
    {
        StringBuilder documentContent = new();
        foreach(var element in documentElements)
        {
            documentContent.Append(element.RenderElement());
        }
        return documentContent.ToString();
    }
}
