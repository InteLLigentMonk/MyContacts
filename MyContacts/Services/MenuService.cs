namespace MyContacts.Services;

public class MenuService
{

    public static void Logo()
    {
        string[] asciiLogo =
        {
            "▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌",
            "▐                                                                                                 ▌",
            "▐  ███╗   ███╗██╗   ██╗     ██████╗ ██████╗ ███╗   ██╗████████╗ █████╗  ██████╗████████╗███████╗  ▌",
            "▐  ████╗ ████║╚██╗ ██╔╝    ██╔════╝██╔═══██╗████╗  ██║╚══██╔══╝██╔══██╗██╔════╝╚══██╔══╝██╔════╝  ▌",
            "▐  ██╔████╔██║ ╚████╔╝     ██║     ██║   ██║██╔██╗ ██║   ██║   ███████║██║        ██║   ███████╗  ▌",
            "▐  ██║╚██╔╝██║  ╚██╔╝      ██║     ██║   ██║██║╚██╗██║   ██║   ██╔══██║██║        ██║   ╚════██║  ▌",
            "▐  ██║ ╚═╝ ██║   ██║       ╚██████╗╚██████╔╝██║ ╚████║   ██║   ██║  ██║╚██████╗   ██║   ███████║  ▌",
            "▐  ╚═╝     ╚═╝   ╚═╝        ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝   ╚═╝   ╚══════╝  ▌",
            "▐                                                                                                 ▌",
            "▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌"
        };

        Console.Clear();
        foreach (string line in asciiLogo)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine("");
    }

    public static void MainMenu()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1: View Contacts");
        Console.WriteLine("2: Add Contact");
        Console.WriteLine("3: Edit Contact");
        Console.WriteLine("4: Delete Contact");
        Console.WriteLine("5: Exit");
    }

    public static void AddContactMenu()
    {
        Console.WriteLine("What type of contact woud you like to add?");
        Console.WriteLine("1: Private");
        Console.WriteLine("2: Business");
        Console.WriteLine("3: Finish adding");
    }
    public static void EditPrivateContactMenu()
    {
        Console.WriteLine("What would you like to edit?");
        Console.WriteLine("1: First Name");
        Console.WriteLine("2: Last Name");
        Console.WriteLine("3: Social Security Number");
        Console.WriteLine("4: Email");
        Console.WriteLine("5: Phone");
        Console.WriteLine("6: Street Address");
        Console.WriteLine("7: Zip Code");
        Console.WriteLine("8: City");
        Console.WriteLine("9: Finish Edit");
    }
    public static void EditBusinessContactMenu()
    {
        Console.WriteLine("What would you like to edit?");
        Console.WriteLine("1: Company");
        Console.WriteLine("2: Contacts Name");
        Console.WriteLine("3: Organization Number");
        Console.WriteLine("4: Email");
        Console.WriteLine("5: Phone");
        Console.WriteLine("6: Street Address");
        Console.WriteLine("7: Zip Code");
        Console.WriteLine("8: City");
        Console.WriteLine("9: Finish Edit");
    }
}
