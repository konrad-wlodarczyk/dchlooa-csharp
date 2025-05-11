
using ShoppingSimulator;

class Program
{
    static void Main(string[] args)
    {
        //Object of simulator class
        Simulator simulator = new Simulator();

        //Memorizing the moves
        simulator.Memorize();

        //Using the real time to simulate the program
        int time = DateTime.Now.Hour;
        Console.WriteLine($"\n[System Time] Current time is: {time}.");

        //Executing the moves and saving the log
        simulator.ExecuteMoves(time);
        simulator.SaveLog();

        Console.WriteLine("Simulation complete.");
    }
}
