using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    class Multi_Catch_demo
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter two numbers: ");

            try
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            }
            catch (DivideByZeroException ex)
            {
                
                Console.Write("Cannot divide by zero. Please try again. "+ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                
                Console.Write("Not a valid number. Please try again. "+ex.StackTrace);
            }
            catch (FormatException ex)
            {
                
                Console.Write("Not a valid number. Please try again. "+ex.InnerException);
            }

            Console.ReadKey();
        }
    }
}
