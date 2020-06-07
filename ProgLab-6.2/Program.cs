using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            for(int i = 1; i < num.Length + 1; i++)
            {
                Console.WriteLine(BinarySearcher<int>.SharrSearch(num, i));
            }
            Console.ReadLine();
        }
    }
}
