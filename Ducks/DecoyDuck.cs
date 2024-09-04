namespace StrategyPattern.Ducks
{
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck");
        }
    }
}
