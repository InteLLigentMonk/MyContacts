namespace Business.Interfaces
{
    public interface IFileStorageService
    {
        List<IContactModel> Load(string fileName);
        void Save(List<IContactModel> contacts, string fileName);
    }
}