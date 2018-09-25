using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Exception_Demo
{
    class FileIO_CreateFile
    {
        static void Main(string[] args)
        {
            try
            {
                  
                string loc = "e:\\abc.txt";
                  
                FileInfo file = new FileInfo(loc);
                  
                file.Create();
                Console.WriteLine("File is created Successfuly");
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
            Console.ReadLine();
        }

    }
}
