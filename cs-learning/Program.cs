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

            /* Random random = new Random();
            //int num = random.Next(1, 20);
            //double num = random.NextDouble();
            double num = random.NextDouble() * (20 - 5) + 5;
            
            Console.WriteLine(num); */

            /* Console.WriteLine("What is the length of the a side?");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("What is the lenght of the b side?");
            double b = Convert.ToDouble(Console.ReadLine());

            double hypotenus = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("The hypotenus is: " + hypotenus); */

            //String fullName = "Erhan Gokce";
            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //Console.WriteLine(fullName);

            //String phoneNumber = "555-555-5555";
            //phoneNumber = phoneNumber.Replace("-", "/");
            //String userName = fullName.Insert(0, "Mr.");

            //String firstName = fullName.Substring(0, 5);// (başlangıç indexi, karakter sayısı)
            //String lastName = fullName.Substring(6, 5);

            //Console.WriteLine("I am " + firstName + " " + lastName);

            //Console.WriteLine(phoneNumber);
            //Console.WriteLine(userName);
            
            /*Console.WriteLine("Enter ur age:  ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            
            else if (age < 0)
            {
                Console.WriteLine("Go born first lol");  
            }

            else
            {
                Console.WriteLine("You are not an adult");
            } */

            /*Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You forgot type your name");
            }

            else
            {
                Console.WriteLine("Hello, " + name);
            } */
            // == equal, != not equal

            /*Console.WriteLine("What is the day today? ");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Today is " + day);
                    break;
                case "Tuesday":
                    Console.WriteLine("Today is Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("Today is Wednesday!");
                    break;
                case "Thursday":
                    Console.WriteLine("Today is Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("Today is Friday!");
                    break;
                case "Saturday":
                    Console.WriteLine("Today is Saturday");
                    break;
                case "Sunday":
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine(day + " is a valid day");
                    break;
            } */
            
            //logical operators, && = AND, || = OR

            Console.WriteLine("What is the tempreture in C?");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 20 && temp <= 30)
            {
                Console.WriteLine("Tempreture is good");
            }
            
            
            Console.ReadKey();
        }
    }
    
}


