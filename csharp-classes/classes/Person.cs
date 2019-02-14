using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_basics
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        //void doesn't return any values
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + LastName);
            
        }
    }
}
