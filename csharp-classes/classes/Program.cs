
using System;
using csharp_basics.Math;

namespace csharp_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person= new Person();
            person.FirstName = "Aaron";
            person.LastName = "Torres";
            person.Introduce();
            
            //Instance of the Calculator Class from the math folder
            // "new" operator allocates memory to that object
            Calculator calculator = new Calculator();
            //calling the add method from Calculator class Name
            int result = calculator.Add(1, 2);
            Console.WriteLine(result);
            
        }        
    }
        
}
