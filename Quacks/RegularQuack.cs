using StrategyPattern.Quacks;

namespace StrategyPattern.classes;

public class RegularQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}