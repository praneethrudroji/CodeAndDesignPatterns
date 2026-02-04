using System;

namespace AmazonInterviewPrep.FactoryPattern;

public class CarFactory : Factory
{
    public override IProduct FactoryMethod()
    {
        return new Car();
    }
}
