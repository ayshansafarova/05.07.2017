using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "admin";
            string password = "admin";
            Console.WriteLine("enter username: ");
            string u = Console.ReadLine();
            Console.WriteLine("enter password: ");
            string p = Console.ReadLine();
            if (u != username || p != password)
            {
                Console.WriteLine("Try again! enter username: ");
                u = Console.ReadLine();
                Console.WriteLine("enter password: ");
                p = Console.ReadLine();
                if (u != username || p != password)
                {
                    Console.WriteLine("You made a mistake twice! enter username: ");
                    u = Console.ReadLine();
                    Console.WriteLine("enter password: ");
                    p = Console.ReadLine();
                    if (u != username || p != password)
                    {
                        Console.WriteLine("Third mistake! Sorry, you can not log in!");
                    }

                    else
                    {
                        Console.WriteLine("You succesfully logged in!");
                    }

                }
                else
                {
                    Console.WriteLine("You succesfully logged in!");
                }
            }
            else
            {
                Console.WriteLine("You succesfully logged in!");
            }

        }
    }
}
