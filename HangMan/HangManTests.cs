// See https://aka.ms/new-console-template for more information
using Xunit;
using Hangman;

namespace HangmanTests;


public class Test{

    [Fact]
    public void IsInputValidShouldValidate()
    {
        // Given
        
        string ValidInput = "G"; 
        Game hg = new Game();
        // When
        bool result =  hg.IsInputValid(ValidInput);
        // Then
        Assert.True(result);
    }

    [Fact]
    public void IsInputValidShouldReturnInvalid()
    {
        // Given
        string Invalid = "5"; 
        Game hg = new Game();
        // When
        bool result = hg.IsInputValid(Invalid);
        // Then
        Assert.False(result);
    }

    [Theory]
    
    [InlineDataAttribute("0")]
    [InlineDataAttribute("8")]
    [InlineDataAttribute(null)]
    [InlineDataAttribute(" ")]

    public void IsInputValid(string letter)
    
    {

        Game hg = new Game();
        bool result = hg.IsInputValid(letter);
        Assert.False(result);
        

    }

}