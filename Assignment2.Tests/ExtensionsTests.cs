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

    [Fact]
    public void WordCount_WhenGivenSentence() {
        // Arrange
        string sut = "Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur. Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";
        
        // Act
        var result = Extensions.WordCount(sut);
        
        // Assert       
        Assert.Equal(68, result);
    }
}
