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
            /* int x; //declaration
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

            int c = 5;
            double d = Convert.ToDouble(c);

            int e = 100;

            String g = "true";
            bool h = Convert.ToBoolean(g);

            Console.WriteLine(h.GetType());
            
            
            String f = Convert.ToString(e);

            Console.WriteLine(e.GetType());

            Console.WriteLine(d.GetType());

            Console.WriteLine(a.GetType());

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
            */
            
            /* Console.WriteLine("what is your name?");
            String name = Console.ReadLine();

            Console.WriteLine("what is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Hello, " + name);
            Console.WriteLine(name + " is " + age + " years old ");
            */

            /* int friends = 5;
            //friends = friends + 1;
            //friends += friends;
            //friends += 2;
            //friends++;

            Console.WriteLine(friends); */

            /* int x = 5;
            int y = -5;
            double z = 4.51;
            //double a = Math.Pow(x, 2); //x^2
            //double b = Math.Sqrt(x);// √5
            //double c = Math.Abs(y); |-5| = 5
            //double d = Math.Round(z);//always rounding nearest
            //double e = Math.Ceiling(z); //always rounding up
            //double f = Math.Floor(z);//always rounding down
            //double g = Math.Max(x, y);//get higher value between these 2 variable
            //double h = Math.Min(x, y); //get lower value between these 2 variable */

            Random random = new Random();
            //int num = random.Next(1, 20);
            //double num = random.NextDouble();
            double num = random.NextDouble() * (20 - 5) + 5;
            
            Console.WriteLine(num);
            
            Console.ReadKey();
        }
    }
    
}


