using System;

namespace AmazonInterviewPrep.FactoryPattern;

public class Car : IProduct
{
    public string Create()
    {
        return " created brand new car ";
    }
}
