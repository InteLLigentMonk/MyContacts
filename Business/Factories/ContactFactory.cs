using Business.Interfaces;
using Business.Models;

namespace Business.Factories;

public class ContactFactory
{
    public static PrivateContactModel NewPrivateContact()
    {
        return new PrivateContactModel()
        {
            Id = Guid.NewGuid().ToString()
        };
    }

    public static BusinessContactModel NewBusinessContact()
    {
        return new BusinessContactModel()
        {
            Id = Guid.NewGuid().ToString()
        };
    }
}
