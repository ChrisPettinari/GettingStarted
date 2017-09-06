using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteFood
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("favorite food?");

            var ans = Console.ReadLine();

            if (ans == "pizza")
            {
                Console.WriteLine("nice");

            }
            else
            {
                Console.WriteLine("no");
            }


            
        }
    }
}
