namespace StrategyPattern.Swim;

public class Sink : ISwimBehavior
{
    public void Swim()
    {
        Console.WriteLine("I sink");
    }
}