using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    class ValueCanNotZeroException : Exception
    {
        public ValueCanNotZeroException(string str):base(str)
        {

        }

    }
    class CustomException_demo2
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter Two value ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                ValueCanNotZeroException e = new ValueCanNotZeroException("Value can not be Zero or negative");
                if (num1 <= 0)
                    throw e;
                double num3 = num1 / num2;
                Console.WriteLine(num1 + "/" + num2 + "=" + num3);

            }
            catch (ValueCanNotZeroException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

    }
}
