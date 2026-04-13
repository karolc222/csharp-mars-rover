//testing if storing and creating positions are done correctly
using NUnit.Framework;
using MarsRover.Console;

namespace MarsRover.Tests;

public class PositionTest
{
    [Test]
    public void CreatePosition()
    {
        //creating an object 
        var position = new Position(1, 2, CompassDirections.North);

        //checking if this object was stored correctly      
        Assert.That(position.x, Is.EqualTo(1));
        Assert.That(position.y, Is.EqualTo(2));
        Assert.That(position.Facing, Is.EqualTo(CompassDirections.North));
    }
}