namespace MarsRover.Console;

// class Position
// {

//     // Perhaps these should be public auto-properties, perhaps private fields... it's up to you!
//     //horizontal
//     public int x { get; set; }
//     //vertical
//     public int y { get; set; }
//     //direction facing: N,E,S,W
//     public CompassDirections facing; // this type can be whatever your direction enum is called

//record is a type like a class, but replaces it to focus on the data that creates objects 
public record Position(int x, int y, CompassDirections Facing);
