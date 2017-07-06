using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("maksimum hed sayini daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("minimum hed sayini daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("reqemin ozunu daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int count = a;
            Console.WriteLine();
            for (int i = 0; i < a - b + 1; i++)
            {
                count--;
                for (int j = count; j >= 0; j--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
}