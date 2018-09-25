using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    class Divide_By_Zero_Demo
    {
        static void Main(string[] args)
        {
            lable:
            try
            {

                Console.WriteLine("Enter first value ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second value ");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(a + "/" + b + "=" + c);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Can not divide by zero please enter correct value");
                goto lable;
            }
            Console.WriteLine("End of the line ");
            Console.ReadLine();
        }
    }
}
