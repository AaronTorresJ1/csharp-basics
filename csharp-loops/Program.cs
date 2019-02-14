using System;

namespace csharp_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop.
            // as long as i is less than or equal to 10, increment i by 1.
            for (int i = 1; i <= 10; i++)
            {
                //check remainder of division of i by 2
                if (i%2 == 0){
                    Console.WriteLine(i);
                }
            
            }
            //Reverse above order
            //When i is greater than 1, decrement i by 1
            for (int i = 10; i >= 1; i--)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //ForEach Loops
            string name = "John Smith";
            //for every character in the variable name. Write the character on a new line.
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            
            //instantiate arrary with new operator
            var numbers = new int [] {1, 2, 3, 4};

            //iterate over array with foreach loop
            foreach (var number in numbers)
            {
                Console.WriteLine(number);

            }

        }
    }
}
