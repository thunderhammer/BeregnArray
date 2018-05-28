using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeregnArray
{
    class Program
    {

        static (string, int ) Test3a() // Tuplet, only available as alternative to returning struct in 4.71 and onwards
        {
            return ("BOT", 1);
        }

        static returtype BeregnOgSorterArray(int[] input)
        {
            returtype r2 = new returtype();
            /*r2.sum = input.Sum();*/
            foreach (var number in input)
            {
                r2.sum += number;
            }

            r2.gennemsnit = Math.Round(r2.sum / input.Count(),2);
            Array.Sort(input);
            foreach (var item in input)
            {
                Console.WriteLine(item.ToString());
            }

            return r2;
        }


        static void Main(string[] args)
        {
            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            var res = BeregnOgSorterArray(test);
            Console.WriteLine(res.sum);
            Console.WriteLine(res.gennemsnit);
            foreach (var item in test)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(Test3a());


        }
    }
    struct returtype
    {
        public double sum;
        public double gennemsnit;
    }
}
