namespace Business.Interfaces
{
    public interface IPrivateContactModel : IContactModel
    {
        string? FirstName { get; set; }
        string? LastName { get; set; }
        string? SocíalSecurityNumber { get; set; }
    }
}