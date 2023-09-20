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
            Console.WriteLine(rover.Execute("RMLM"));
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

    public Rover()
    {
        Reset();
    }

    private void Reset()
    {
        xPosition = 0;
        yPosition = 0;
        direction = 0;
    }
    public string Execute(string command)
    {        
        string position = "";

        foreach (char c in command) {

            if (c == 'R')
                direction = direction == 3 ? 0 : ++direction;

            if (c == 'L')
                direction = direction == 0 ? 3 : --direction;

            if (c == 'M')
            {
                xPosition += direction == 1 ? 1 : direction == 3 ? -1 : 0;
                yPosition += direction == 0 ? 1 : direction == 2 ? -1 : 0;
            }

            if (xPosition >= 10 || xPosition < 0 || yPosition >= 10 || yPosition < 0)
                Reset();

            position = xPosition + ":" + yPosition + ":" + directions[direction];            
        }
        return position;
    }
}