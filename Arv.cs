using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_OOP
{
    public class Hälsning
    {
        // Attribut
        string attributHej;


        // Första metoden
        public virtual void hej() 
        {
            Console.WriteLine("Hejsan!");
        }
    }

    // Andra klass som ärver ifrån "Hälsning"
    public class Tjena : Hälsning
    {
        string attributTjena;

        // Anvädner första metoden
        public new void hej()
        {
            Console.WriteLine("Tjena kompis");
        }

        public void käka()
        {
            Console.WriteLine("Ska vi käka pizza?");
        }
    }
}
