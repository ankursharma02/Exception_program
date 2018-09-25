using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Exception_Demo
{
    class FileNotFound_exception
    {
        public static void Main()
        {
            try
            {
                FileStream fs = new FileStream("e://en.txt", FileMode.Open);

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.ReadLine();
        }
    }
}
