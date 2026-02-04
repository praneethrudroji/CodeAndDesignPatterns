using System;

namespace AmazonInterviewPrep.FactoryPattern;

public class SimpleFactory
{
    public virtual IProduct FactoryMethod(string productType)
    {
        return productType switch
        {
            "Car" => new Car(),
            "Bike" => new Bike(),
            _ => new Bike(),
        };
    }

    public string CreateProduct(string productType)
    {
        var creator = FactoryMethod(productType);

        var result = $"working on creating....{creator.Create()}";

        return result;
    }
}
