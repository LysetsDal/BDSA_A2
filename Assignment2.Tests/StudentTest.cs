using CsvHelper;

namespace Assignment2.Tests;

public class StudentTest
{
    [Fact]
    public void Assert_Status_Freshly_Enrolled()
    {
        //Arrange
        var now = DateTime.Now;
        var student = new Student(1, "Nicolai", "Friis", now, now.AddYears(3), now.AddYears(3));
        
        //Act
        //Assert
        Assert.Equal(Student.State.Active, student.Status);
    }
    
    [Fact]
    public void Assert_Status_New()
    {
        //Arrange
        var now = DateTime.Now.AddDays(1);
        var student = new Student(1, "Nicolai", "Friis", now, now.AddYears(2), now.AddYears(3));
        
        //Act
        //Assert
        Assert.Equal(Student.State.New, student.Status);
    }
    
    [Fact]
    public void Assert_Status_Dropout()
    {
        //Arrange
        var now = DateTime.Now.AddYears(-4);
        var student = new Student(1, "Nicolai", "Friis", now, now.AddYears(2), now.AddYears(3));
        
        //Act
        //Assert
        Assert.Equal(Student.State.Dropout, student.Status);
    }
    
    [Fact]
    public void Assert_Status_Graduated()
    {
        //Arrange
        var now = DateTime.Now.AddYears(-4);
        var student = new Student(1, "Nicolai", "Friis", now, now.AddYears(3), now.AddYears(3));
        
        //Act
        //Assert
        Assert.Equal(Student.State.Graduated, student.Status);
    }
    

    [Fact]
    public void Assert_ToString_Format_Correct()
    {
        //Arrange
        var now = DateTime.Now;
        var student = new Student(1, "Nicolai", "Friis", now, now.AddYears(3), now.AddYears(3));

        //Act
        var output = student.ToString();

        //Assert
        output.Should().BeEquivalentTo("Id: 1, Name: Nicolai Friis");
    }


}