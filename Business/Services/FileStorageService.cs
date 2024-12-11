using System.Text.Json;
using Business.Interfaces;

namespace Business.Services;

public class FileStorageService : IFileStorageService
{
    private readonly string _directoryPath = "C:/WebDev/MyContacts/Storage";
    private string _filePath = string.Empty;
    private readonly JsonSerializerOptions _options = new()
    {
        WriteIndented = true,
        Converters = { new ContactModelConverter() }
    };


    public void Save(List<IContactModel> contacts, string fileName)
    {
        try
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
            var json = JsonSerializer.Serialize(contacts, _options);
            _filePath = Path.Combine(_directoryPath, fileName);
            File.WriteAllText(_filePath, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
    }



    public List<IContactModel> Load(string fileName)
    {
        try
        {
            _filePath = Path.Combine(_directoryPath, fileName);
            if (!File.Exists(_filePath))
            {
                return [];
            }
            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<IContactModel>>(json, _options)!;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadKey();
            return [];
        }
    }
}
