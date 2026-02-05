using System;

namespace AmazonInterviewPrep.FactoryPattern;

public abstract class Factory
{
    public abstract IProduct FactoryMethod();
    
    public string CreateProduct()
    {
        var creator = FactoryMethod();

        var result = $"working on creating....{creator.Create()}";

        return result;
    }
}
