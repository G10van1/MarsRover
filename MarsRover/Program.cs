using System.Collections;
namespace MarsRover
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Rover rover = new Rover();
            Console.WriteLine(rover.Execute("MMMMMMMMMM"));
            Console.WriteLine(rover.Execute("RMLM"));
            Console.WriteLine(rover.Execute("MMMMMMMMM"));
            Console.WriteLine(rover.Execute("RMMMMMLMMMMM"));
        }
    }
}

public interface IRover
{
    public string Execute(string command);
}
public class Rover: IRover
{
    int xPosition;
    int yPosition;
    int direction;
    char[] directions = { 'N', 'E', 'S', 'W' };
    const int START_POSITION = 0;
    const int MAX_POSITION = 9;
    const int NORTH_INDEX = 0;
    const int EAST_INDEX = 1;
    const int SOUTH_INDEX = 2;
    const int WEST_INDEX = 3;

    public Rover()
    {
        Reset();
    }

    private void Reset()
    {
        xPosition = START_POSITION;
        yPosition = START_POSITION;
        direction = NORTH_INDEX;
    }
    public string Execute(string command)
    {        
        string position = "";

        foreach (char c in command) {

            if (c == 'R')
                direction = direction == WEST_INDEX ? NORTH_INDEX : ++direction;

            if (c == 'L')
                direction = direction == NORTH_INDEX ? WEST_INDEX : --direction;

            if (c == 'M')
            {
                xPosition += direction == EAST_INDEX ? 1 : direction == WEST_INDEX ? -1 : 0;
                yPosition += direction == NORTH_INDEX ? 1 : direction == SOUTH_INDEX ? -1 : 0;
            }

            if (xPosition > MAX_POSITION || xPosition < START_POSITION || yPosition > MAX_POSITION || yPosition < START_POSITION)
                Reset();

            position = xPosition + ":" + yPosition + ":" + directions[direction];            
        }

        return position;
    }
}