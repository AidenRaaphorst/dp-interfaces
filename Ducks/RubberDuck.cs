using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.classes;

namespace StrategyPattern.Ducks
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck");
        }
    }
}
