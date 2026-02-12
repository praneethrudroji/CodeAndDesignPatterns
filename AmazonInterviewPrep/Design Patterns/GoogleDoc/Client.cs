using System;

namespace AmazonInterviewPrep.Design_Patterns.GoogleDoc;

public class Client
{
    public static void CreateDocument()
    {
        Document document = new();
        IPersistence persistence = new SaveToFile();
        DocumentEditor documentEditor = new(document, persistence);

        documentEditor.AddText("Hello, How are you?");      
        documentEditor.AddNewLine();      
        documentEditor.AddTab();      
        documentEditor.AddTab();      
        documentEditor.AddText("Can you see this image? It is hilarious");      
        documentEditor.AddNewLine();  
        documentEditor.AddNewLine();  
        documentEditor.AddImage("c://test//path");    

        documentEditor.Render();

        documentEditor.Save();  
    }
}
