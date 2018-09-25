using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    class Argoutofrange_demo
    {
        public static void Main()
        {
            try
            {
                string s1 = "test".Substring(-1);
            }
            catch (Exception e)
            {
                if(e is ArgumentOutOfRangeException|| e is ArgumentNullException)
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("end of line");
            Console.ReadLine();
        }
    }
}
