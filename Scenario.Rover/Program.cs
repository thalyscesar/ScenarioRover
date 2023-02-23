using Scenario.Rover.Enums;
using Scenario.Rover.Interfaces;
using System;
using System.IO;
using System.Linq;

namespace Scenario.Rover
{
    public class Program
    {
        static void Main(string[] args)
        {

            string input = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Input", "PlanPositions.txt"));
            var separators = input.Replace("\r", "").Split('\n');

            var positionMax = separators[0];
            var max = positionMax.Split(',');

            IPosition position = new Position();
            position.MaximoX = int.Parse(max[0]);
            position.MaximoY = int.Parse(max[1]);

            for (int i = 0; i < separators.Length; i++)
            {
                if (i == 0) continue;

                if (separators[i].Contains(","))
                {
                    var coordinatesByComma = separators[i].Where(x => char.IsNumber(x)).ToList();
                    position.X = int.Parse(coordinatesByComma[0].ToString());
                    position.Y = int.Parse(coordinatesByComma[1].ToString());

                    if (Enum.TryParse(separators[i].FirstOrDefault(c => char.IsLetter(c)).ToString(), out Directions direction))
                    {
                        position.Direction = direction;
                    }
                    else
                    {
                        Console.Write("Orientation invalid:");
                        throw new Exception("Orientation invalid.");
                    }
                }
                else if (separators[i].Contains(""))
                {
                    try
                    {
                        position.Load(separators[i]);
                        position.Begin();
                        position.End();
                        position.Clear();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
