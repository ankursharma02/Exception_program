using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    class Arg_ex
    {
        static void Main()
        {
            // Demonstrate the argument null exception.
            try
            {
                A(null);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            // Demonstrate the general argument exception.
            try
            {
                A("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            // Flow path without exception.
            Console.WriteLine(A("test"));
            Console.ReadLine();
        }

        static int A(string argument)
        {
            // Handle null argument.
            if (argument == null)
            {
                throw new ArgumentNullException("argument");
            }
            // Handle invalid argument.
            if (argument.Length == 0)
            {
                throw new ArgumentException("Zero-length string invalid", "argument");
            }
            return argument.Length;
        }
    }

}

