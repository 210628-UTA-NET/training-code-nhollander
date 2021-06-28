using System; //import
using HouseFunction;
/*
        We use PascalCase for naming convention
*/

namespace CoreC_
{
    class Program
    {
        //We can use underscores for private variables to access them easier in our code
        private static string _first = "Hello";
        private string _last = "World";
        /*Main method is the first method that will be run with the command dotnet run
            Static means that the class does not have to be instantiated to be used
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Whatever I want");
            Test obj = new Test();
            obj.SomeMethod();

            Console.WriteLine(_first + _last);
            Console.WriteLine(obj.SomeMethod());

            House objHouse = new House();
            Console.WriteLine(objHouse.getColor);
            objHouse.setColor("blue");
            Console.WriteLine(objHouse.getColor());
        }
    }


    class Test
    {
        public void SomeMethod(){
            Console.WriteLine("someMethod was called");
        }
    }
}
