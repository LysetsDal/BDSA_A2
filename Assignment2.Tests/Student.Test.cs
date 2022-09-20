namespace Assignment2.Tests;

public class StudentTest
{

    [Fact]
    public void Assert_ToString_Format_Correct()
    {
        //Arrange
        var student = new Student(1, "Nicolai", "Friis");

        //Act
        var output = student.ToString();

        //Assert
        output.Should().BeEquivalentTo("Id: 1, Name: Nicolai Friis");
    }


}