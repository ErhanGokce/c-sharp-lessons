using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //declaration
            x = 100; // initialization

            int y = 200; //declaration + initialization

            int z = x + y;

            int age = 18; //whole integer
            double height = 300.5; //decimal number

            bool allowed = false;// boolean can be only true or false

            char symbol = '@';//we can only assign single chracter only with char and we have to use ' not this "

            String Name = "Erhan";//text

            String emailDomain = "gmail.com";

            String Email = Name + symbol + emailDomain;

            double a = 5.14;
            int b = Convert.ToInt32(a);

            Console.WriteLine(b);

            Console.WriteLine("My email is: " + Email);

            Console.WriteLine("Hello, " + Name);

            Console.WriteLine("What is email symbol? " + symbol);
            

            Console.WriteLine("is friendly fire allowed? " + allowed);

            Console.WriteLine(height);

            Console.WriteLine("Your age is: " + age);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            
            Console.ReadLine();
        }
    }
    
}


