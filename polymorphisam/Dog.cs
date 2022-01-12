using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgaram.polymorphisam
{
    internal class Dog:Animal// child class
        // this class inhert the Animal class to get the data 
    {
        public override void Display()// method calling for Dog
        {
            Console.WriteLine("Dog sounds bow bow");
        }
    }
}
