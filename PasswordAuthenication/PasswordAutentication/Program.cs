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
            bool login = false;

            int loginTries = 0;

            string username, password;

            while (login == false && loginTries < 3)
            {
                System.Console.WriteLine("Input username");
       

             username = System.Console.ReadLine();

                System.Console.WriteLine("Input password");

                password = System.Console.ReadLine();

                if (username == "root" && password == "letmein")
                    login = true;
                else if (username != "root" || password != "letmein")
                    Console.WriteLine("Incorrect username or password");
                

                loginTries++;
            }

            if (login)
            {
                System.Console.WriteLine("Username and password authenticated.. you may proceed");
            }
            else if (loginTries == 3)
            {
                System.Console.WriteLine("Too many incorrect login attempts!  Try again later!");
            }
        }
    }
}
