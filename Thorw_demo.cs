using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    class Thorw_demo
    {
        public static void Main()
        {
            try
            {
                string name;
                Console.WriteLine("Enter Name ");
                name = Console.ReadLine();
               
                if (name.Equals(null) || name.Trim().Equals(""))
                    throw new Exception("Name can not be empty");
                Console.WriteLine("Name =" + name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();

        }
    }
}
