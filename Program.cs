using ObjectOrientedProgaram.polymorphisam;
using ObjectOrientedProgaram.overloading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overloading = ObjectOrientedProgaram.overloading.Overloading;

namespace ObjectOrientedProgaram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Car car = new Car();
            // creating a object for class car
            //car.Name = "TATA"; // calling the method by using with respect object
            //car.Model = 2022;
            // Console .WriteLine(car.Name+"    "+ car.Model);
            //car.Colour();
            //car.Display();
            // Animal animal = new Animal(); // craeting a object 
            //Animal pig = new Pig(); // craeting object for a Pig class
            //Animal dog = new Dog(); // craeting object for a Dog class
            //pig.Name = "pig";
            //Console .WriteLine(pig.Name); // print the name 
            //pig.Display(); // display sound of that animal
            //dog.Name = "Dog";
            //Console .WriteLine(dog.Name);
            //dog.Display();
            Overloading num = new Overloading(); //creating object 
            num.Arthamatic(10, 20); 
            num.Arthamatic(20, 30, 40);
            num.Arthamatic(10.3, 40);

           

        }
    }
}
