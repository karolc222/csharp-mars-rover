using NUnit.Framework;
using MarsRover.Console;
using MarsRover.Console.InputParser;

namespace MarsRover.Tests;

public class DirectionParserTests
{
    [Test]
    public void ParsesNorthCorrectly()
    {
        //Arrange
        var parser = new DirectionParser();
        //Act
        var result = parser.Parse("N");
        //Assert 
        Assert.That(result[0], Is.EqualTo(CompassDirections.North));
    }

    [Test]
    public void ParseEastCorrectly()
    {
        //Arrange
        var parser = new DirectionParser();
        //Act
        List<CompassDirections> result = parser.Parse("E");
        //Assert 
        Assert.That(result[0], Is.EqualTo(CompassDirections.East));
    }

    [Test]
    public void ParseSouthCorrectly()
    {
        //Arrange
        var parser = new DirectionParser();
        //Act
        List<CompassDirections> result = parser.Parse("S");
        //Assert 
        Assert.That(result[0], Is.EqualTo(CompassDirections.South));
    }
    
    [Test]
    public void ParseWestCorrectly()
    {
        //Arrange
        var parser = new DirectionParser();
        //Act
        List<CompassDirections> result = parser.Parse("W");
        //Assert 
        Assert.That(result[0], Is.EqualTo(CompassDirections.West));
    }
}

