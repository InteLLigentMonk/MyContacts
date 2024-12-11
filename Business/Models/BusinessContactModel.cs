using Business.Interfaces;

namespace Business.Models;

public class BusinessContactModel : ContactModel, IBusinessContactModel
{
    public string? Company { get; set; }
    public string? ContactName { get; set; }
    public string? OrganisationNumber { get; set; }
}
