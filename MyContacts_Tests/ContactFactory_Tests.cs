using Business.Factories;
using Business.Models;

namespace MyContacts_Tests;

public class ContactFactory_Tests
{
    [Fact]
    public void NewPrivateContact_ShouldReturnPrivateContactModelWithGuid()
    {
        // Arrange
        var expected = new PrivateContactModel()
        {
            Id = Guid.NewGuid().ToString()
        };

        //Act
        var actual = ContactFactory.NewPrivateContact();

        //Assert
        Assert.True(Guid.TryParse(actual.Id, out Guid guidResult));
        Assert.IsType<PrivateContactModel>(actual);
    }

    [Fact]
    public void NewBusinessContact_ShouldReturnPrivateContactModelWithGuid()
    {
        // Arrange
        var expected = new PrivateContactModel()
        {
            Id = Guid.NewGuid().ToString()
        };

        //Act
        var actual = ContactFactory.NewPrivateContact();

        //Assert
        Assert.True(Guid.TryParse(actual.Id, out Guid guidResult));
        Assert.IsType<PrivateContactModel>(actual);
    }
}
