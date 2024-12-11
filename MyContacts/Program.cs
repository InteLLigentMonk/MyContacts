using Business.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyContacts.Services;
using Business.Interfaces;
using Business.Models;
using MyContacts.Helpers;

var host = new HostBuilder()
    .ConfigureServices((hostContext, services) =>
    {
        services.AddSingleton<IFileStorageService, FileStorageService>();
        services.AddSingleton<Business.Interfaces.IContactServices, MyContacts.Services.ContactServices>();
        services.AddTransient<IBusinessContactModel, BusinessContactModel>();
        services.AddTransient<IPrivateContactModel, PrivateContactModel>();

    })
    .Build();

var contactServices = host.Services.GetRequiredService<Business.Interfaces.IContactServices>();

bool isRunning = true;

do
{
    MenuService.Logo();
    MenuService.MainMenu();
    string choice = Console.ReadLine()!;
    switch (choice)
    {
        case "1":
            MenuService.Logo();
            contactServices.ListContacts();
            MenuCloseouts.BackToMain();
            break;
        case "2":
            MenuService.Logo();
            contactServices.Add();   
            break;
        case "3":
            contactServices.Edit();
            break;
        case "4":
            contactServices.Delete();
            break;
        case "5":
            if(MenuCloseouts.Exit())
                isRunning = false;
            break;
        default:
            MenuCloseouts.InvalidOption();
            MenuCloseouts.BackToMain();
            break;
    }
} while (isRunning);

