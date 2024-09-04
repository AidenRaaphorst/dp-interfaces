using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Quacks;
using StrategyPattern.Swim;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        protected IQuackBehavior _quackBehavior;
        protected IFlyBehavior _flyBehavior;
        protected ISwimBehavior _swimBehavior;

        public abstract void Display();

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformSwim()
        {
            _swimBehavior.Swim();
        }

        public void SetFlyBehavior(IFlyBehavior f)
        {
            _flyBehavior = f;
        }

        public void SetQuackBehavior(IQuackBehavior q)
        {
            _quackBehavior = q;
        }

        public void SetSwimBehavior(ISwimBehavior s)
        {
            _swimBehavior = s;
        }
    }
}
