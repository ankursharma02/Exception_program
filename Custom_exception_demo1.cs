using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message)
            : base(message)
        {

        }
    }
    public class Custom_exception_demo1
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age ");
                validate(Convert.ToInt32(Console.ReadLine()));
            }
            catch (InvalidAgeException e) { Console.WriteLine(e.Message); }
            Console.WriteLine("Thanks to visit");
            Console.ReadLine();
        }
    }
}
