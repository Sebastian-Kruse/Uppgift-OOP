using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_OOP
{
    public class Polymorfism : Hälsning
    {
        public string spanska;

        public override void hej()
        {
            Console.WriteLine("Hola mannen");
        }
    }
}
