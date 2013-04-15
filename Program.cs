using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableScope
{
    class Program
    {
        // fields to contain the class data 
        static void Main(string[] args)
        {
            int i = 800000;
            short x = 5;
            float f = 20.0f;

            f = i;

            i = (int)f;
            Console.ReadLine();
        }
    }
}
