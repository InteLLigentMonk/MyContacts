namespace Business.Interfaces
{
    public interface IContactModel
    {
        string? Id { get; set; }
        string? Email { get; set; }
        string? Phone { get; set; }
        string? StreetAddress { get; set; }
        int ZipCode { get; set; }
        string? City { get; set; }
    }
}