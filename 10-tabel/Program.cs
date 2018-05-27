using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_tabel
{
    class Program
    {
        static void CreateTable()
        {

            for (int i = 1; i < 11; i++)
            {
                for (int ii = 1; ii < 11; ii++)
                {
                    string tal = (i * ii).ToString();
                    if ((i * ii) > 50) Console.ForegroundColor = ConsoleColor.Yellow;
                    else Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(tal.PadLeft(4));
                }
            }

        }
        static void Main(string[] args)
        {
            CreateTable();
        }
    }
}
