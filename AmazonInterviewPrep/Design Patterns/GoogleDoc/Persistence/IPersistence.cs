using System;

namespace AmazonInterviewPrep.Design_Patterns.GoogleDoc;

public interface IPersistence
{
    void Save(Document document);
}