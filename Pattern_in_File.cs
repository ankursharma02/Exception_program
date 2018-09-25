using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Exception_Demo
{
    class Pattern_in_File
    {
        public static void Main()
        {
            FileStream f=new FileStream("e://pattern.txt",FileMode.OpenOrCreate);
            
            StreamWriter sr = new StreamWriter(f);
            int no = 0;
            for (int i = 1; i <= 5; i++)
            {
                no = i;
                for (int j = 1; j <= i; j++)
                {
                    sr.Write(no);
                    no += 5 - j;
                }
                sr.WriteLine();
            }
            sr.Flush();
          
        }
    }
}
