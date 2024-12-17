using Business.Interfaces;
using Moq;

namespace MyContacts_Tests.Services;

public class FileStorageService_Tests
{
    [Fact]
    public void Save_ShouldSaveContactsToFile()
    {
        // Arrange

        var mockFileStorageService = new Mock<IFileStorageService>();
        mockFileStorageService.Setup(fs => fs.Save(It.IsAny<List<IContactModel>>(), It.IsAny<string>()));
        var fileStorageService = mockFileStorageService.Object;
        var contacts = new List<IContactModel>();


        // Act
        fileStorageService.Save(contacts, "contacts.json");

        // Assert
        mockFileStorageService.Verify(fs => fs.Save(contacts, "contacts.json"), Times.Once);
    }

    [Fact]
    public void Load_ShouldLoadContactsFromFile()
    {
        // Arrange
        var mockFileStorageService = new Mock<IFileStorageService>();
        mockFileStorageService.Setup(fs => fs.Load(It.IsAny<string>())).Returns([]);
        var fileStorageService = mockFileStorageService.Object;
        // Act
        var contacts = fileStorageService.Load("contacts.json");
        // Assert
        mockFileStorageService.Verify(fs => fs.Load("contacts.json"), Times.Once);
        Assert.IsType<List<IContactModel>>(contacts);
    }
}
