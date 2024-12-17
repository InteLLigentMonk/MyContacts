using Business.Factories;
using Business.Interfaces;
using Business.Models;

namespace MyContacts_Tests.Factories;

public class ContactFactory_Tests
{
    [Fact]
    public void NewPrivateContact_ShouldReturnPrivateContactModel()
    {
        // Arrange
        var expected = new PrivateContactModel()
        {
            Id = Guid.NewGuid().ToString()
        };

        //Act
        var actual = ContactFactory.NewPrivateContact();

        //Assert
        Assert.True(Guid.TryParse(actual.Id, out _));
        Assert.IsType<PrivateContactModel>(actual);
        Assert.IsAssignableFrom<IPrivateContactModel>(actual);
    }

    [Fact]
    public void NewBusinessContact_ShouldReturnBusinessContactModelWithGuid()
    {
        // Arrange
        var expected = new BusinessContactModel()
        {
            Id = Guid.NewGuid().ToString()
        };

        //Act
        var actual = ContactFactory.NewBusinessContact();

        //Assert
        Assert.True(Guid.TryParse(actual.Id, out _));
        Assert.IsType<BusinessContactModel>(actual);
        Assert.IsAssignableFrom<IBusinessContactModel>(actual);
    }
}
