using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    class Checked_unchecked_demo
    {
        public static void Main()
        {
            unchecked
            {
                int value = int.MaxValue;
                Console.WriteLine(value + 2);
                Console.ReadLine();
            }
            checked
            {
                int value = int.MaxValue;
                Console.WriteLine(value + 2);
                Console.ReadLine();
            }
        }
    }
}
