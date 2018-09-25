using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    class Indexoutofrange_demo
    {
        public static void Main()
        {
            try
            {
                int[] arr = new int[5];
                Console.WriteLine("Enter value in arr ");
                for (int i = 0; i <arr.Length; i++)
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("value in arr  are");
                for (int i = 0; i <= arr.Length; i++)
                    Console.WriteLine(arr[i]);


            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();
        }
    }
}
