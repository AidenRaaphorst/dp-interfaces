using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.classes;

namespace StrategyPattern.Ducks
{
    internal class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Redhead Duck");
        }
    }
}
