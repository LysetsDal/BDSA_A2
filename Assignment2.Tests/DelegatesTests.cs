namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void String_To_Reverse_Order()
    {
        //Arrange
        Delegates d = new Delegates();
        var list = "Hej med dig";

        //Act
        var temp = d.CustomReverse(list);

        //Assert
        temp.Should().BeEquivalentTo("gid dem jeH");

    }

    [Fact]
    public void Two_decimals_product_should_be_36()
    {
        //Arrange
        Delegates d = new Delegates();

        //Act
        var temp = d.ProductNums(6.0, 6.0);

        //Assert
        temp.Should().Be(36.0);

    }

    [Fact]
    public void Numerical_equal_42_should_return_true()
    {
        //Arrange
        Delegates d = new Delegates();

        //Act
        var temp = d.NumericalEqual(42, "0042");

        //Assert
        temp.Should().Be(true);
    }
}
