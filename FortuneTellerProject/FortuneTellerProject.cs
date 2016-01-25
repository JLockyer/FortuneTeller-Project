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
            while (true)
            {
                Console.WriteLine("Welcome to the \"Master Fortune\"");
                Console.WriteLine("You may restart or quit at any time by entering \"Restart\" or \"Quit\"");
                Console.WriteLine();

                //Part 1 user input to the fortune teller quesions

                Console.WriteLine("What is your first name? ");
                string firstName = Console.ReadLine();
                if (firstName.ToLower() == "quit")
                {
                    Console.WriteLine("Nobody likes a quiter...");
                    break;
                }
                if (firstName.ToLower() == "restart")
                {
                    continue;
                }


                Console.WriteLine("What is your last name? ");
                string lastName = Console.ReadLine();
                if (lastName.ToLower() == "quit")
                {
                    Console.WriteLine("Nobody likes a quiter...");
                    break;
                }
                if (lastName.ToLower() == "restart")
                {
                    continue;
                }

                Console.WriteLine("How old are you? ");
                string enterAge = Console.ReadLine();
                int age;
                if (enterAge.ToLower() == "quit")
                {
                    Console.WriteLine("Nobody likes a quiter...");
                    break;
                }
                else if (enterAge.ToLower() == "restart")
                {
                    continue;
                }
                    else
                    {
                    bool ans = int.TryParse(enterAge, out age);
                    }

                Console.WriteLine("What month were you born in? ");
                string month = Console.ReadLine();
                if (month.ToLower() == "quit")
                {
                    Console.WriteLine("Nobody likes a quiter...");
                    break;
                }
                if (month.ToLower() == "restart")
                {
                    continue;
                }

                Console.WriteLine("What is your favorite color? (ROYGBIV)");

                Console.WriteLine("Type: \"Help\" if you do not know what ROYGBIV is");

                string color = Console.ReadLine().ToLower();
                if (color.ToLower() == "quit")
                {
                    Console.WriteLine("Nobody likes a quiter...");
                    break;
                }
                if (color.ToLower() == "restart")
                {
                    continue;
                }

                while (true)
                {
                    if (color == "help")
                    {
                        Console.WriteLine("List of ROYGBIV colors: ");
                        Console.WriteLine("Red" + "\nOrange" + "\nYellow" + "\nGreen" + "\nBlue" + "\nIndigo" + "\nViolet");
                        Console.WriteLine("Enter favorite color:");
                        color = Console.ReadLine().ToLower();

                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("How many siblings do you have? ");
                string enterSib = Console.ReadLine();
                int siblings;
                if (enterSib.ToLower() == "quit")
                {
                    Console.WriteLine("Nobody likes a quiter...");
                    break;
                }
                else if (enterSib.ToLower() == "restart")
                {
                    continue;
                }
                else
                {
                    bool sib = int.TryParse(enterSib, out siblings);
                }



                //Part 2 giving answers to the user
                string retirement;
                string[] years = { "15 years", "20 years" };

                if (age % 2 == 0)
                {
                    retirement = years[0];
                }
                else
                {
                    retirement = years[1];
                }
                string sibl = siblings.ToString();
                string[] places = { "Russia", "New Jersey", "Australia", "Greenland", "West Virginia" };

                if (siblings == 0)
                {
                    sibl = places[0];
                }
                else if (siblings == 1)
                {
                    sibl = places[1];
                }
                else if (siblings == 2)
                {
                    sibl = places[2];
                }
                else if (siblings == 3)
                {
                    sibl = places[3];
                }
                else if (siblings >= 4)
                {
                    sibl = places[4];
                }

                string[] vehicle = { "Segway", "Motorcycle", "Scooter", "Fighter Jet", "Sport Car","Jet Pack", "Magic Carpet" };

                if (color.ToLower() == "red")
                {
                    color = vehicle[0];
                }
                else if (color.ToLower() == "orange")
                {
                    color = vehicle[1];
                }
                else if (color.ToLower() == "yellow")
                {
                    color = vehicle[2];
                }
                else if (color.ToLower() == "green")
                {
                    color = vehicle[3];
                }
                else if (color.ToLower() == "blue")
                {
                    color = vehicle[4];
                }
                else if (color.ToLower() == "indigo")
                {
                    color = vehicle[5];
                }
                else if (color.ToLower() == "violet")
                {
                    color = vehicle[6];
                }

                string fullName = firstName + lastName;
                string m = month[0].ToString().ToLower();
                string b = month[1].ToString().ToLower();
                string h = month[2].ToString().ToLower();

                string[] money = { "$1000", "$100000", "$1000000", "0" };
                if (fullName.Contains(m))
                {
                    fullName = money[0];
                }
                else if (fullName.Contains(b))
                {
                    fullName = money[1];
                }
                else if (fullName.Contains(h))
                {
                    fullName = money[2];
                }

                //Part 3: the full fortune teller result

                Console.WriteLine(string.Concat(firstName, " ", lastName, " will retire in ", retirement, " ", fullName, " in the bank, a vacation home in ", sibl, " and a ", color, "."));

                Console.WriteLine("Would you like another fortune?");
                Console.WriteLine("Enter \"Yes\" to restart or \"no\" to quit");
                string response = Console.ReadLine().ToLower();
                if (response == "yes")
                {
                    continue;
                }
                else if (response == "no")
                {
                    Console.WriteLine("Noboby likes a quiter...");
                    break;
                }
                
            }
           
        }
    }
}
