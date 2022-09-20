namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void IsSecure_WhenGivenSecureWebpage()
    {
       // Arrange
        Uri sut = new Uri("https://github.com/");
        
       // Act
        var result = Extensions.IsSecure(sut);

       // Assert
       Assert.Equal(true, result);
    }
}
