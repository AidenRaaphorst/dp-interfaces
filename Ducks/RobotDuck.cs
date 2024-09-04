namespace StrategyPattern.Ducks;

internal class RobotDuck : Duck
{
    public override void Display()
    {
        Console.WriteLine("I'm a robot duck");
    }
}