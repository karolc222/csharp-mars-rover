using NUnit.Framework;
using MarsRover.Console;
using MarsRover.Console.InputParser;

namespace MarsRover.Tests;

public class InstructionParserTests
{
    [Test]
    public void ParseLCorrectly()
    {
        //Arrange
        var parser = new InstructionParser();
        //Act
        var result = parser.Parse("L");
        //Assert 
        Assert.That(result[0], Is.EqualTo(Instruction.L));
    }

    [Test]
    public void ParseMCorrectly()
    {
        //Arrange
        var parser = new InstructionParser ();
        //Act
        List<Instruction> result = parser.Parse("M");
        //Assert 
        Assert.That(result[0], Is.EqualTo(Instruction.M));
    }

    [Test]
    public void ParseRCorrectly()
    {
        //Arrange
        var parser = new InstructionParser();
        //Act
        List<Instruction> result = parser.Parse("R");
        //Assert 
        Assert.That(result[0], Is.EqualTo(Instruction.R));
    }
}

