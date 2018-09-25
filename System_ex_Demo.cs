using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    class System_ex_Demo
    {
        public static void Main()
        {
            try
            {
                int[] arr = new int[5];
                arr[10] = 25;
            }
            catch (SystemException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
