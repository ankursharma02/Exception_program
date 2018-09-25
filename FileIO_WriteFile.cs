using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Exception_Demo
{
    class FileIO_WriteFile
    {
        static void Main(string[] args)
        {
            try
            {
                // Specifying file location  
                string loc = "e:\\abc.txt";
                // Creating FileInfo instance  
                FileInfo file = new FileInfo(loc);
                // Creating an empty file  

                StreamWriter sr = file.CreateText();
                sr.WriteLine("Some text in abc.txt file ");
                sr.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
            Console.WriteLine("writing complete");
            Console.ReadLine();
           
        }

    }
}
