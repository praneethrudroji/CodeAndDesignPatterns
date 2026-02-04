using System;

namespace AmazonInterviewPrep.FactoryPattern;

public class BikeFactory : Factory
{
    public override IProduct FactoryMethod()
    {
        return new Bike();
    }
}
