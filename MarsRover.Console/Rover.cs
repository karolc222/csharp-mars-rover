namespace MarsRover.Console
{
    public class Rover
    {
        //position 
        //direction 

        //position property
        public void MoveForward()
        {
            //takes current position
            //changes position/coordinates 
            //square North = x, y + 1
            //square East = x + 1, y

        }

        public void Rotate(current Direction, new Direction )
        {

            //only changes Facing direction 

            //L : spins 90 degrees left without moving form current point
            //R : spins 90 degrees right
            //M : move forward by one grid point, maintaining the same heading/orientation
            //output : final position = coordinates, facing direction
            
            //current direction + instruction(L/R) = new direction

            // if current facing = North + instruction R => East
            // if current facing = North + instruction L => West
        }
    }
}