using System;
using System.IO;
using System.Text;

namespace AmazonInterviewPrep.Design_Patterns.GoogleDoc;

public class SaveToFile : IPersistence
{
    public void Save(Document document)
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "../../../output.txt"); // PWD path
        try
        {
            string content = document.Render();
            File.WriteAllText(filePath, content);
            Console.WriteLine($"File saved to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}