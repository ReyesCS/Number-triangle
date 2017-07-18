using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_crazy_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //pinting a numbers triangle
            Console.Write("input number of rows: ");

            int rows = Convert.ToInt32
                (Console.ReadLine());

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(i);
                Console.Write("\n");

            }
        }
    }
}
