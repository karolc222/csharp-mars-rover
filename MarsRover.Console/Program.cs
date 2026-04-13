using MarsRover.Console.InputParser;

namespace MarsRover.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //store input as string 
            string plateauInput = "5 5";
            string positionInput = "1 2 N";
            string instructionInput = "LMLMMLLMMMR";

            //create parsers 
            var instructionParser = new InstructionParser();
            var directionParser = new DirectionParser();

            //call the parsers 
            var instructions = instructionParser.Parse(instructionInput);
            var direction = directionParser.Parse("N");

            System.Console.WriteLine("Program is running");

            foreach (var instruction in instructions)
             {
            System.Console.WriteLine(instruction);
             }   
        }
        
    }
}
