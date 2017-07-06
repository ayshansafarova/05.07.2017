using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herf daxil edin: ");
            char c = Convert.ToChar(Console.ReadLine());
            if (char.IsLetter(c))
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'u' || c == 'o')
                {
                    Console.WriteLine("Bu saitdir!");
                }
                else
                {
                    Console.WriteLine("Bu samitdir!");
                }
            }
            else
            {
                Console.WriteLine("Bu ki herf deyil!");
            }
        }
    }
}