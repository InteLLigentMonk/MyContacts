using MyContacts.Services;

namespace MyContacts.Helpers;

public class MenuCloseouts
{
    public static bool AddAnother()
    {
        Console.Clear();
        MenuService.Logo();
        Console.WriteLine("Contact added Succesfully!");
        Console.WriteLine("Add more users? (y/n)");
        if (Console.ReadLine() == "y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void BackToMain()
    {
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
        Console.Clear();
    }

    public static bool Exit()
    {
        Console.WriteLine("Are you sure you want to exit? (y/n)");
        string choice = Console.ReadLine()!;
        if (choice == "y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void InvalidOption()
    {
        Console.Clear();
        Console.WriteLine("Invalid Option, please enter a valid value");
    }

    public static void InvalidId(string id)
    {
        Console.Clear();
        MenuService.Logo();
        Console.Write("Contact with id: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{id}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" could not be found \n");
        Console.WriteLine("Press any key to return...");
    }

    public static void Updated()
    {
        Console.WriteLine("Updated!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
        MenuService.Logo();
    }
    public static void Deleted()
    {
        Console.WriteLine("Deleted!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
