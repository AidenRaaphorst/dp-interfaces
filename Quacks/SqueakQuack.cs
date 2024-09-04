using StrategyPattern.Quacks;

namespace StrategyPattern.classes;

public class SqueakQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}