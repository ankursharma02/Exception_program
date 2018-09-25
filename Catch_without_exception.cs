using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    class Catch_without_exception
    {
        public static void Main()
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
            }
            catch
            {
                Console.WriteLine("catch block");
            }
            Console.WriteLine($"Result is {div}");
            Console.ReadLine();
        }
    }
}
