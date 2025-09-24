// Game where you pick between 5 doors
using System.Collections;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Welcome.");
Console.WriteLine("1: Start Adventure.");
Console.WriteLine("2: Quit.");
Random rand = new Random();
string tscreen = Console.ReadLine() + "";
switch (tscreen)
{

    case "1":
        Console.WriteLine("Welcome to the 5 doors of destiny");
        while (tscreen == "1")
        {
            Console.WriteLine("Which door do you choose?");
            string door = Console.ReadLine() + "";
            switch (door)
            {
                case "1":
                    int door1 = rand.Next(1, 6);
                    if (door1 == 5)
                    {
                        Console.WriteLine("You found the treasure door");
                        tscreen = "2";
                        break;
                    }
                    else if (door1 == 1 || door1 == 2 || door1 == 3)
                    {
                        Console.WriteLine("You died");
                        tscreen = "2";
                        break;
                    }
                    else if (door1 == 4)
                        Console.WriteLine("Nothing in there. Try again?");
                        break;
                case "2":

                    int door2 = rand.Next(1, 6);
                    if (door2 == 5)
                    {
                        Console.WriteLine("You found the treasure door");
                        tscreen = "2";
                        break;
                    }
                    else if (door2 == 1 || door2 == 2 || door2 == 3)
                    {
                        Console.WriteLine("You died");
                        tscreen = "2";
                        break;
                    }
                    else if (door2 == 4)
                        Console.WriteLine("Nothing in there. Try again?");
                        break;
                case "3":
                    int door3 = rand.Next(1, 6);
                    if (door3 == 5)
                    {
                        Console.WriteLine("You found the treasure door");
                        tscreen = "2";
                        break;
                    }
                    else if (door3 == 1 || door3 == 2 || door3 == 3)
                    {
                        Console.WriteLine("You died");
                        tscreen = "2";
                        break;
                    }
                    else if (door3 == 4)
                        Console.WriteLine("Nothing in there. Try again?");
                        break;
                case "4":
                    int door4 = rand.Next(1, 6);
                    if (door4 == 5)
                    {
                        Console.WriteLine("You found the treasure door");
                        tscreen = "2";
                        break;
                    }
                    else if (door4 == 1 || door4 == 2 || door4 == 3)
                    {
                        Console.WriteLine("You died");
                        tscreen = "2";
                        break;
                    }
                    else if (door4 == 4)
                        Console.WriteLine("Nothing in there. Try again?");
                        break;
                case "5":
                    int door5 = rand.Next(1, 6);
                    if (door5 == 5)
                    {
                        Console.WriteLine("You found the treasure door");
                        tscreen = "2";
                        break;
                    }
                    else if (door5 == 1 || door5 == 2 || door5 == 3)
                    {
                        Console.WriteLine("You died");
                        tscreen = "2";
                        break;
                    }
                    else if (door5 == 4)
                        Console.WriteLine("Nothing in there. Try again?");
                        break;
                default:
                    Console.WriteLine($"{door} is not an option.");
                    break;
            }
        }
        break;
    case "2":
        Console.WriteLine("Bye");
        break;
    default:
        Console.WriteLine($"{tscreen} is not an option.");
        break;
}
