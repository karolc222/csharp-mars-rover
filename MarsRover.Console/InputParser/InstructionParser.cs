//returns a list of Instructions types when given a string 
//input layer 
namespace MarsRover.Console.InputParser;

public class InstructionParser
{
    public List<Instruction> Parse(string input)
    {

        var instructions = new List<Instruction>();

        foreach (char c in input)
        {
            if (c == 'L')
            {
                instructions.Add(Instruction.L);
            }
            else if (c == 'M')
            {
                instructions.Add(Instruction.M);

            } else if (c == 'R') {

                instructions.Add(Instruction.R);
            }

        }
        return instructions;
    }
}