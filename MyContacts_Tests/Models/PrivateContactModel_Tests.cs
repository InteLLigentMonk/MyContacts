using Business.Interfaces;
using Business.Models;

namespace MyContacts_Tests.Models;

public class PrivateContactModel_Tests
{
    [Fact]
    public void NewPrivateContactModel_ShouldReturnNewPrivateContactModel()
    {
        // Arrange & Act
        var actual = new PrivateContactModel();

        // Assert
        Assert.IsType<PrivateContactModel>(actual);
        Assert.IsAssignableFrom<IContactModel>(actual);

    }
}
