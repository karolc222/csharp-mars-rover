using NUnit.Framework;
using MarsRover.Console;

namespace MarsRover.Tests;

public class InstructionParserTests
{
    [Test]
    public void ChecksThatTheFirstInstructionIsCorrect()
    {
        //Arrange
        var parser = new InstructionParser();
        //Act
        var result = parser.Parse("L");
        //Assert 
        Assert.That(result[0], Is.EqualTo(Instruction.L));


    }
}