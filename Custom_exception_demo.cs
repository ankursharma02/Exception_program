using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    class InvalidAmountException : Exception
    {
        public InvalidAmountException(string str) : base(str)
        { 
            
        }
    }
    class Money
    {
        private int rs, paisa;
        public void read()
        {
            int r, p;
            r = Convert.ToInt32(Console.ReadLine());
            p = Convert.ToInt32(Console.ReadLine());
            if (r <= 0 || p >= 100)
            {
                InvalidAmountException e1 = new InvalidAmountException("Amount is invalid");
                throw e1;
            }
            else
            {
                rs = r;
                paisa = p;
            }
        }
    }
    class Custom_exception_demo
    {
        public static void Main()
        {
            Money m1 = new Money();
            try
            {
                Console.WriteLine("Enter rs and paisa");
                m1.read();
                Console.WriteLine("Money added success");

            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine("Invalid amount");
                Console.WriteLine(ex.Message);
            }
                        Console.ReadLine();
        }
         
    }
}
