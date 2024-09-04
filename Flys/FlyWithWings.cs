using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern.classes;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying using my wings!");
    }
}