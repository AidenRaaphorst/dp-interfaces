using StrategyPattern.classes;
using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Swim;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            RedheadDuck redheadDuck = new RedheadDuck();
            DecoyDuck decoyDuck = new DecoyDuck();
            RubberDuck rubberDuck = new RubberDuck();
            RobotDuck robotDuck = new RobotDuck();

            mallardDuck.SetQuackBehavior(new RegularQuack());
            mallardDuck.SetFlyBehavior(new FlyWithWings());
            mallardDuck.SetSwimBehavior(new Float());
            mallardDuck.Display();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
            mallardDuck.PerformSwim();
            Console.WriteLine();

            redheadDuck.SetQuackBehavior(new RegularQuack());
            redheadDuck.SetFlyBehavior(new FlyWithWings());
            redheadDuck.SetSwimBehavior(new Float());
            redheadDuck.Display();
            redheadDuck.PerformQuack();
            redheadDuck.PerformFly();
            redheadDuck.PerformSwim();
            Console.WriteLine();

            decoyDuck.SetQuackBehavior(new MuteQuack());
            decoyDuck.SetFlyBehavior(new FlyNoWay());
            decoyDuck.SetSwimBehavior(new Float());
            decoyDuck.Display();
            decoyDuck.PerformQuack();
            decoyDuck.PerformFly();
            decoyDuck.PerformSwim();
            Console.WriteLine();

            rubberDuck.SetQuackBehavior(new SqueakQuack());
            rubberDuck.SetFlyBehavior(new FlyNoWay());
            rubberDuck.SetSwimBehavior(new Float());
            rubberDuck.Display();
            rubberDuck.PerformQuack();
            rubberDuck.PerformFly();
            rubberDuck.PerformSwim();
            Console.WriteLine();

            robotDuck.SetQuackBehavior(new RegularQuack());
            robotDuck.SetFlyBehavior(new FlyNoWay());
            robotDuck.SetSwimBehavior(new Sink());
            robotDuck.Display();
            robotDuck.PerformQuack();
            robotDuck.PerformFly();
            robotDuck.PerformSwim();
        }
    }
}