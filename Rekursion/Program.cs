using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursion
{
    class Program
    {
        static void RecursiveWrite(int number, int stop)
        {
            Console.WriteLine(number);
            if (number == stop)
                return;
            else
            {
                number++;
                RecursiveWrite(number, stop);
            }

        } 
        static void Main(string[] args)
        {
            RecursiveWrite(1, 10);
        }
    }
}
