using System;

namespace AmazonInterviewPrep.Design_Patterns.GoogleDoc;

public class DocumentEditor(Document document, IPersistence db)
{
    readonly Document document = document;
    readonly IPersistence db = db;

    public void AddText(string text)
    {
        document.AddElement(new TextElement(text));
    }

    public void AddNewLine()
    {
        document.AddElement(new NewLineElement());
    }

    public void AddTab()
    {
        document.AddElement(new TabElement());
    }

    public void AddImage(string filePath)
    {
        document.AddElement(new ImageElement(filePath));
    }

    public void Render()
    {
        Console.WriteLine(document.Render());
    }

    public void Save()
    {
        db.Save(document);
    }
}
