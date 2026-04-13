namespace MarsRover.Console.InputParser;

public class DirectionParser
{
    public List<CompassDirections> Parse(string input)
    {

        var direction = new List<CompassDirections>();

        foreach (char cd in input)
        {
            if (cd == 'N')
            {
                direction.Add(CompassDirections.North);
            }
            else if (cd == 'E')
            {
                direction.Add(CompassDirections.East);

            }
            else if (cd == 'S')
            {

                direction.Add(CompassDirections.South);
            }
            if (cd == 'W')
            {
                direction.Add(CompassDirections.West);
            }

        }
        return direction;
    }
}