using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first name? ");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name? ");
            string lastName = Console.ReadLine();
            Console.WriteLine("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What month were you born in? ");
            string month = Console.ReadLine();
            Console.WriteLine("What is your favorite color? (ROYGBIV)");
            Console.WriteLine("Type: \"Help\" if you do not know what ROYGBIV is");
            string color = Console.ReadLine();
            while(true)
            {
                if (color == "help")
                {
                    Console.WriteLine("List of ROYGBIV colors: ");
                    Console.WriteLine("Red" + "\nOrange" + "\nYellow" + "\nGreen" + "\nBlue" + "\nIndigo" + "\nViolet");
                    Console.WriteLine("Enter favorite color:");
                    color = Console.ReadLine();

                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("How many siblings do you have? ");
            int siblings = int.Parse(Console.ReadLine());
            if (age % 2 == 0)
            {
                Console.WriteLine("You will retire in 15 years!");
            }
            else
            {
                Console.WriteLine("You will retire in 20 years!");
            }
            if (siblings == 0)
            {
                    Console.WriteLine("You will live in: Russia");
            }
            else if (siblings == 1)
            {
                Console.WriteLine("You will live in New Jersey");
            }
            else if (siblings == 2 )
            {
                Console.WriteLine("You will live in Australia");
            }
            else if (siblings == 3)
            {
                Console.WriteLine("You will live in Greenland");
            }
            else if (siblings >= 4 )
            {
                Console.WriteLine("You will live in West Virgina");
            }
            if (color == "red")
            {
                Console.WriteLine("You will get around by Segway");      
            }
            else if (color == "orange")
            {
                Console.WriteLine("You will get around by Bus");
            }
            else if (color == "yellow")
            {
                Console.WriteLine("You will get around by Scooter")
            }
            else if (color == "green")
            {
                Console.WriteLine("You will get around by Figher Jet");
            }
            else if (color == "blue")
            {
                Console.WriteLine("You will get around by Jetpack");
            }
            else if (color == "indigo")
            {
                Console.WriteLine("You will get around by Foreign Sport Car");
            }
            else if (color == "violet")
            {
                Console.WriteLine("You will get around by Magic Carpet");
            }
            char[] firstN = firstName.ToCharArray();
            char[] lastN = lastName.ToCharArray();
            char[] birth = month.ToCharArray();
            if (firstN.Contains(month[0]))
            {
                if (true)
                {
                    Console.WriteLine("You will have $1000 in the bank");
                }
            }
        }
    }
}
