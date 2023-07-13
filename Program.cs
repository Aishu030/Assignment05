using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 04
            //ASSIGNMENT 05
            //Advanced decision making constructs and control flow

            int attempts = 3;
            string username = "aishu";
            string password = "aishu123";

            while (attempts > 0)
            {
                Console.Write("Enter username: ");
                string enteredUsername = Console.ReadLine();

                Console.Write("Enter password: ");
                string enteredPassword = Console.ReadLine();

                if (enteredUsername == username && enteredPassword == password)
                {
                    Console.WriteLine("Login successful.");
                    break;
                }
                else if (enteredUsername == username)
                {
                    Console.WriteLine("Invalid password.");
                }
                else
                {
                    Console.WriteLine("Invalid username.");
                }

                attempts--;
            }

            if (attempts == 0)
            {
                Console.WriteLine("Login failed.");
            }

            Console.ReadLine();
        }
    }
}
    


