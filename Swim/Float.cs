namespace StrategyPattern.Swim;

public class Float : ISwimBehavior
{
    public void Swim()
    {
        Console.WriteLine("I float");
    }
}