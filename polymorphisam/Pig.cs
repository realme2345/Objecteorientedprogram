using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgaram.polymorphisam
{
    internal class Pig:Animal // child class
        // class inhert the parent class to get the data from the respected class
    {
        public override void Display() //Pig class method 
        {
            Console.WriteLine(" It sounds wee wee");
        }
    }
}
