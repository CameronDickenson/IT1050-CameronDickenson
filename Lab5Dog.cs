using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    class Dog
    {
        public string Name { get; set; }

        // Add bark() method


        public string bark;
        public static void bark();

        {
         Console.WriteLine("{0} is Barking...", Name);
        }




    // Add doTrick() method
    public string doTrick;

    public static void doTrick(trickName);

    {Console.WriteLine("{0} is so smart! {0} is doing a(n) {1}", name, trickName);
}


}
}













//Scope: double height, double width.Anything within the () in a method header.
//Static vs.Non-StaticStatic: static or not static, if static you can access information all across the code.If not static then must fetch information another way.
//Return Type: Double in this example.Signifies how the program returns information. Can be void, or int aswell
//Method Name(Identifier): getArea in this example.Tells the code where to go to for information.
//Parameters: Public in this example.Tells the code the access restrictions if any.Public don’t have restrictions private do.
//Method Body: Return height* width; in this example.Marks the area of code that must be executed.

//User defined method is written by the user and are hidden from other methods. Methods provided by the framework are able to be reused from several locations in an app. When creating user-defined methods we should take into consideration to not “reinvent the wheel.

//The difference between a static and non-static method is that a non-static method is allowed to access all the non-static fields in an object. While the static method does not have access to any of the objects non-static fields