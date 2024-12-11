using Business.Interfaces;

namespace Business.Models;

public abstract class ContactModel : IContactModel
{
    public string? Id { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? StreetAddress { get; set; }
    public int ZipCode { get; set; }
    public string? City { get; set; }
}
