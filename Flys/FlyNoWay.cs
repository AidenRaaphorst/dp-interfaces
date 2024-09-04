using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern.classes;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly!");
    }
}