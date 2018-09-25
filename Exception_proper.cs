using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    class Exception_proper
    {
        public static void Main()
        {
            Exc_demo();
            Console.ReadLine();
        }
        public static void Exc_demo()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine("e=" + e);
                Console.WriteLine("=============");
                Console.WriteLine("e.HelpLink=" + e.HelpLink);
                Console.WriteLine("=============");

                Console.WriteLine("e.HResult=" + e.HResult);
                Console.WriteLine("=============");

                Console.WriteLine("e.InnerException=" + e.InnerException);
                Console.WriteLine("=============");
                Console.WriteLine("e.Message=" + e.Message);
                Console.WriteLine("=============");
                Console.WriteLine("e.StackTrace=" + e.StackTrace);
                Console.WriteLine("=============");

                Console.WriteLine("e.Data=" + e.Data);
                Console.WriteLine("=============");

                Console.WriteLine("e.TargetSite=" + e.TargetSite);
                Console.WriteLine("=============");




            }
        }
    }
}
