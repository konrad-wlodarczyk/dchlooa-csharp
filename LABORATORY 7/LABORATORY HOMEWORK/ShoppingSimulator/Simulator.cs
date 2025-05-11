using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSimulator
{
    class Simulator
    {
        private List<Move> moves = new List<Move>();

        public void Memorize()
        {
            Console.WriteLine("| W/Up-arrow - north | S/Down-arrow - south | A/Left-arrow - west | D/Right-arrow - east | Backspace - go back one step | Enter - accept |");

            while (true)
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
                {
                    moves.Add(new MoveNorth());
                    Console.WriteLine("Added tip: MoveNorth");
                }
                else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                {
                    moves.Add(new MoveSouth());
                    Console.WriteLine("Added tip: MoveSouth");
                }
                else if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
                {
                    moves.Add(new MoveEast());
                    Console.WriteLine("Added tip: MoveWest");
                }
                else if (key == ConsoleKey.D || key == ConsoleKey.RightArrow)
                {
                    moves.Add(new MoveWest());
                    Console.WriteLine("Added tip: MoveEast");
                }
                else if (key == ConsoleKey.Backspace)
                {
                    if (moves.Count == 0)
                    {
                        Console.WriteLine("No tip to remove...");
                    }
                    else if (moves.Count > 0)
                    {
                        moves.RemoveAt(moves.Count - 1);
                        Console.WriteLine("Removed the last tip.");
                    }
                }
                else if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Saving the entered tips.");
                    break;
                }
            }
        }

        public void ExecuteMoves(int CurrentTime)
        {
            foreach (var move in moves)
            {
                {
                    move.Execute(CurrentTime);
                }
            }

        }

        public void SaveLog()
        {
            using(StreamWriter writer = new StreamWriter("log.txt"))
            {
                foreach (var move in moves)
                {
                    writer.WriteLine(move.GetType().Name);
                }
            }

            Console.WriteLine("The tips have been saved to log.txt file.");
        }
    }
}
