using System;

namespace AmazonInterviewPrep.Design_Patterns.GoogleDoc;

public class ImageElement(string filePath) : IDocumentElement
{
    string IDocumentElement.RenderElement()
    {
        return $"Image: [{filePath}]";
    }
}
