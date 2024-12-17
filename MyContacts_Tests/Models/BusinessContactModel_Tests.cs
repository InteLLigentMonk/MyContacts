using Business.Interfaces;
using Business.Models;

namespace MyContacts_Tests.Models;

public class BusinessContactModel_Tests
{
    [Fact]
    public void NewBusinessContactModel_ShouldReturBusinessContactModel()
    {

        //Arrage & Act
        var expected = new BusinessContactModel();

        //Assert
        Assert.IsType<BusinessContactModel>(expected);
        Assert.IsAssignableFrom<IBusinessContactModel>(expected);
        Assert.IsAssignableFrom<IContactModel>(expected);

    }
}
