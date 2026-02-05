using System;

namespace AmazonInterviewPrep.FactoryPattern;

public class Bike : IProduct
{
    public string Create()
    {
        return " created brand new bike ";
    }
}
