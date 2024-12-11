namespace Business.Interfaces
{
    public interface IBusinessContactModel : IContactModel
    {
        string? Company { get; set; }
        string? ContactName { get; set; }
        string? OrganisationNumber { get; set; }
    }
}