using StrategyPattern.Quacks;

namespace StrategyPattern.classes;

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<<Silence>>");
    }
}