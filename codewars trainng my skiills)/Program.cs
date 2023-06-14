using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars_trainng_my_skiills_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = "is2 Thi1s T4est 3a ds6 lo5ck";
            
            Console.WriteLine(string.Join(" ", words.Split(' ').OrderBy(x => x.ToList().Find(c => char.IsDigit(c)))));

            Console.WriteLine();
            
  
            Console.ReadKey();
        }
    }
}
