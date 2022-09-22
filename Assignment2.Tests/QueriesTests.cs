using CsvHelper;

namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Assert_Rowling_LINQ_and_Extension_Identical()
    {
        //Arrange
        var wizard = WizardCollection.Create();
        
        //Act
        var resultRowling = wizard.QueryRowling();
        var resultRowLinq = wizard.QueryRowlingLinq();
        
        //Assert
        resultRowling.Should().BeEquivalentTo(resultRowLinq);
    }

    [Fact]
    public void Assert_Rowling_Wizards_Returned()
    {
        //Arrange
        var wizard = WizardCollection.Create();
        IEnumerable<string> wizards = new[]
            { "Lord Voldemort", "Albus Percival Wulfric Brian Dumbledore", "Harry Potter" };
        
        //Act
        var result = wizard.QueryRowling();
        
        //Assert
        result.Should().BeEquivalentTo(wizards);
    }
    
    [Fact]
    public void Assert_Sith_LINQ_and_Extension_Identical()
    {
        //Arrange
        var wizard = WizardCollection.Create();
        
        //Act
        var resultSith = wizard.QueryFirstSith();
        var resultSithLinq = wizard.QueryFirstSithLinq();
        
        //Assert
        resultSith.Should().Be(resultSithLinq);
    }

    [Fact]
    public void Assert_First_Sith_Returned()
    {
        //Arrange
        var wizard = WizardCollection.Create();
        
        //Act
        var result = wizard.QueryFirstSith();
        
        //Assert
        Assert.Equal(1977, result);
    }
    
    [Fact]
    public void Assert_Wizards_HP_LINQ_and_Extension_Identical()
    {
        //Arrange
        var wizard = WizardCollection.Create();
        
        //Act
        var resultRowling = wizard.QueryWizardsHP();
        var resultRowLinq = wizard.QueryWizardsHPLINQ();
        
        //Assert
        resultRowling.Should().BeEquivalentTo(resultRowLinq);
    }
    
    [Fact]
    public void Assert_HP_Wizards_Returned()
    {
        //Arrange
        var wizard = WizardCollection.Create();
        IEnumerable<Tuple<string, int?>> wizards = new[]
            { new Tuple<string, int?>("Lord Voldemort", 2005), new Tuple<string, int?>("Albus Percival Wulfric Brian Dumbledore", 2001), new Tuple<string, int?>("Harry Potter", 2001) };
        
        //Act
        var result = wizard.QueryWizardsHP();
        
        //Assert
        result.Should().BeEquivalentTo(wizards);
    }
    
    [Fact]
    public void Assert_Wizards_Creator_Reversed_LINQ_and_Extension_Identical()
    {
        //Arrange
        var wizard = WizardCollection.Create();
        
        //Act
        var result = wizard.QueryWizardsGroupCreatorReversed();
        var resultLinq = wizard.QueryWizardsGroupCreatorReversedLINQ();
        
        //Assert
        result.Should().BeEquivalentTo(resultLinq);
    }
    
    [Fact]
    public void Assert_Wizards_Creator_Reversed_Correct()
    {
        //Arrange
        var wizard = WizardCollection.Create();
        IEnumerable<string> wizards = new[]
            { "Prospero", "Jafar", "Gargamel", "Glinda the Good Witch", "Merlin", "Sauron", "Gandalf the White", "Lord Voldemort", "Albus Percival Wulfric Brian Dumbledore", "Harry Potter", "Ursula", "Darth Vader", "The White Witch"};
        
        //Act
        var result = wizard.QueryWizardsGroupCreatorReversed();
        
        //Assert
        result.Should().BeEquivalentTo(wizards);
    }
}
