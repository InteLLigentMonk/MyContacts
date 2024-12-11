using Business.Factories;
using Business.Interfaces;
using Business.Models;
using MyContacts.Helpers;

namespace MyContacts.Services;

public class ContactServices : IContactServices
{
    private readonly IFileStorageService _fileStorageService;
    private readonly List<IContactModel> _contacts;

    public ContactServices(IFileStorageService fileStorage)
    {
        _fileStorageService = fileStorage;
        _contacts = _fileStorageService.Load("contacts.json");
    }

    public void ListContacts()
    {
        foreach (var contact in _contacts)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Id: {contact.Id}");
            Console.ForegroundColor = ConsoleColor.White;
            if (contact is BusinessContactModel bc)
            {
                Console.WriteLine($"{bc.Company}");
                Console.WriteLine($"{bc.ContactName}");
                Console.WriteLine($"{bc.OrganisationNumber}");
            }
            else if (contact is PrivateContactModel pc)
            {
                Console.WriteLine($"{pc.FirstName} {pc.LastName}");
                Console.WriteLine($"{pc.SocíalSecurityNumber}");
            }
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"Phone: {contact.Phone}");
            Console.WriteLine($"Address: {contact.StreetAddress}, {contact.ZipCode}, {contact.City}");
            Console.WriteLine("-------------------------------------------------");
        }
    }

    public void Add()
    {
        bool adding = true;

        do
        {
            Console.Clear();
            MenuService.Logo();
            MenuService.AddContactMenu();
            var option = Console.ReadLine()!;
            switch (option)
            {
                case "1":
                    AddPrivate();
                    break;
                case "2":
                    AddBusiness();
                    break;
                case "3":
                    adding = false;
                    break;
                default:
                    MenuCloseouts.ValidOption();
                    Console.ReadKey();
                    break;
            }

        }
        while (adding);
        _fileStorageService.Save(_contacts, "contacts.json");
    }

    private void AddPrivate()
    {
        Console.Clear();
        MenuService.Logo();
        var contact = ContactFactory.NewPrivateContact();
        Console.WriteLine("Enter first name:");
        contact.FirstName = Console.ReadLine()!;
        Console.WriteLine("Enter last name:");
        contact.LastName = Console.ReadLine()!;
        Console.WriteLine("Enter your social security number:");
        contact.SocíalSecurityNumber = Console.ReadLine()!;
        Console.WriteLine("Enter email:");
        contact.Email = Console.ReadLine()!;
        Console.WriteLine("Enter phone number:");
        contact.Phone = Console.ReadLine()!;
        Console.WriteLine("Enter street address:");
        contact.StreetAddress = Console.ReadLine()!;
        Console.WriteLine("Enter zip code:");
        contact.ZipCode = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter city:");
        contact.City = Console.ReadLine()!;
        _contacts.Add(contact);
    }

    private void AddBusiness()
    {
        Console.Clear();
        MenuService.Logo();
        var contact = ContactFactory.NewBusinessContact();
        Console.WriteLine("Enter company name:");
        contact.Company = Console.ReadLine()!;
        Console.WriteLine("Enter company organization number:");
        contact.OrganisationNumber = Console.ReadLine()!;
        Console.WriteLine("Enter contact person's name:");
        contact.ContactName = Console.ReadLine()!;
        Console.WriteLine("Enter email:");
        contact.Email = Console.ReadLine()!;
        Console.WriteLine("Enter phone number:");
        contact.Phone = Console.ReadLine()!;
        Console.WriteLine("Enter street address:");
        contact.StreetAddress = Console.ReadLine()!;
        Console.WriteLine("Enter zip code:");
        contact.ZipCode = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter city:");
        contact.City = Console.ReadLine()!;
        _contacts.Add(contact);
    }

    public void Edit()
    {
        Console.WriteLine("Enter the id of the contact you want to edit:");
        string id = Console.ReadLine()!;
        var contact = _contacts.FirstOrDefault(c => c.Id == id);

        Console.Clear();
        MenuService.Logo();
        bool editing = true;
        if (contact == null)
        {
            Console.WriteLine("Contact not found");
            MenuCloseouts.ValidId(id);
            Console.ReadKey();
            return;
        }
        else if (contact is BusinessContactModel bc)
        {
            do
            {
                MenuService.EditBusinessContactMenu();
                _contacts.Remove(contact);
                var option = Console.ReadLine()!;
                switch (option)
                {
                    case "1":
                        Console.WriteLine($"Current company name is {bc.Company}.\n");
                        Console.WriteLine("Enter new company name:");
                        bc.Company = Console.ReadLine()!;
                        MenuCloseouts.Updated();
                        break;
                    case "2":
                        Console.WriteLine($"Current contacts name is {bc.ContactName}.\n");
                        Console.WriteLine("Enter new contact name:");
                        bc.ContactName = Console.ReadLine()!;
                        MenuCloseouts.Updated();
                        break;
                    case "3":
                        Console.WriteLine($"Current organization number is {bc.OrganisationNumber}.\n");
                        Console.WriteLine("Enter new organization number:");
                        bc.OrganisationNumber = Console.ReadLine()!;
                        MenuCloseouts.Updated();
                        break;
                    case "4":
                        Console.WriteLine($"Current Email is {bc.Email}.\n");
                        Console.WriteLine("Enter new email:");
                        bc.Email = Console.ReadLine()!;
                        MenuCloseouts.Updated();
                        break;
                    case "5":
                        Console.WriteLine($"Current phone number is {bc.Phone}.\n");
                        Console.WriteLine("Enter new phone number:");
                        bc.Phone = Console.ReadLine()!;
                        MenuCloseouts.Updated();
                        break;
                    case "6":
                        Console.WriteLine($"Current street adress is {bc.StreetAddress}.\n");
                        Console.WriteLine("Enter new street address:");
                        bc.StreetAddress = Console.ReadLine()!;
                        MenuCloseouts.Updated();
                        break;
                    case "7":
                        Console.WriteLine($"Current zipcode is {bc.ZipCode}.\n");
                        Console.WriteLine("Enter new zipcode:");
                        bc.ZipCode = Convert.ToInt32(Console.ReadLine());
                        MenuCloseouts.Updated();
                        break;
                    case "8":
                        Console.WriteLine($"Current City is {bc.City}.\n");
                        Console.WriteLine("Enter new city:");
                        bc.City = Console.ReadLine()!;
                        MenuCloseouts.Updated();
                        break;
                    case "9":
                        editing = false;
                        break;
                    default:
                        MenuCloseouts.ValidOption();
                        Console.ReadKey();
                        break;
                }
                _contacts.Add(bc);
            } while (editing);
        }
        else if (contact is PrivateContactModel pc)
        {
            do
            {
                MenuService.EditPrivateContactMenu();
                _contacts.Remove(contact);

                var option = Console.ReadLine()!;
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter new first name:");
                        pc.FirstName = Console.ReadLine()!;
                        MenuCloseouts.Updated();
                        break;
                    case "2":
                        Console.WriteLine("Enter new last name:");
                        pc.LastName = Console.ReadLine()!;
                        MenuCloseouts.Updated();
                        break;
                    case "3":
                        Console.WriteLine("Enter new social security number:");
                        pc.SocíalSecurityNumber = Console.ReadLine()!;
                        MenuCloseouts.Updated();
                        break;
                    case "4":
                        Console.WriteLine("Enter new email:");
                        pc.Email = Console.ReadLine()!;
                        MenuCloseouts.Updated();
                        break;
                    case "5":
                        Console.WriteLine("Enter new phone number:");
                        pc.Phone = Console.ReadLine()!;
                        MenuCloseouts.Updated();
                        break;
                    case "6":
                        Console.WriteLine("Enter new street address:");
                        pc.StreetAddress = Console.ReadLine()!;
                        MenuCloseouts.Updated();
                        break;
                    case "7":
                        Console.WriteLine("Enter new zip code:");
                        pc.ZipCode = Convert.ToInt32(Console.ReadLine());
                        MenuCloseouts.Updated();
                        break;
                    case "8":
                        Console.WriteLine("Enter new city:");
                        pc.City = Console.ReadLine()!;
                        MenuCloseouts.Updated();
                        break;
                    case "9":
                        editing = false;
                        break;
                    default:
                        MenuCloseouts.ValidOption();
                        Console.ReadKey();
                        break;
                }
                _contacts.Add(pc);
            } while (editing);
        }
        _fileStorageService.Save(_contacts, "contacts.json");
    }

    public void Delete()
    {
        MenuService.Logo();
        Console.WriteLine("Enter the id of the contact you want to delete:");
        string id = Console.ReadLine()!;
        var contactToDelete = _contacts.FirstOrDefault(c => c.Id == id);
        if (contactToDelete == null)
        {
            Console.WriteLine("Contact not found");
            MenuCloseouts.ValidId(id);
            Console.ReadKey();
            return;
        }
        _contacts.Remove(contactToDelete);
        _fileStorageService.Save(_contacts, "contacts.json");
        MenuCloseouts.Deleted();
    }
}
