using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_OOP
{
    abstract class Hus
    {
        public abstract void el();
    }

    class Tv : Hus
    {
        public override void el()
        {
            Console.WriteLine("En tv behöver el");
        }
    }

    class Dator : Hus
    {
        public override void el()
        {
            Console.WriteLine("En dator behöver också el");
        }
    }
}
