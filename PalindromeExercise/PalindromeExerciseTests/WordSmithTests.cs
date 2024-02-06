using PalindromeExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PalindromeExerciseTests;

public class WordSmithTests
{
    [Theory]
    [InlineData("noon", true)]
    [InlineData("wow", true)]
    [InlineData("level", true)]
    [InlineData("civic", true)]
    [InlineData("poptart", false)]
    [InlineData("bob", true)]
    public void IsAPalindromeTest(string word, bool expected) 
    {
        //Arrange
        var ws = new WordSmith();

        //Act
        var actual = ws.IsAPalindrom(word);

        //Assert
        Assert.Equal(expected, actual);

    }
}
