using Business.Interfaces;

namespace Business.Models;

public class PrivateContactModel : ContactModel, IPrivateContactModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? SocíalSecurityNumber { get; set; }
}
