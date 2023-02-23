using Scenario.Rover.Enums;
using Scenario.Rover.Interfaces;
using Scenario.Rover.Orientation;
using System;
using System.Collections.Generic;

namespace Scenario.Rover
{
    public class Position : IPosition
    {
        private List<IDirection> directions = new List<IDirection>();

        public int X { get; set; }
        public int Y { get; set; }
        public int MaximoX { get; set; }
        public int MaximoY { get; set; }
        public Directions Direction { get; set; }

        public void Load(string letters)
        {
            foreach (var letter in letters)
            {
                IDirection state = null;
                switch (letter)
                {
                    case 'M':
                        state = new MoveDirecion(this);
                        break;
                    case 'L':
                        state = new Left(this);
                        break;
                    case 'R':
                        state = new Rigth(this);
                        break;
                    default:
                        Console.WriteLine($"Invalid character {letter}");
                        break;
                }

                directions.Add(state);
            }
        }

        private void ValidationPosition()
        {
            if (this.X < 0 || this.X > this.MaximoX || this.Y < 0 || this.Y > this.MaximoY)
            {
                throw new Exception($"Position cannot exceed the limit maximum ({this.MaximoX}, {this.MaximoY}). Position current ({this.X}, {this.Y})");
            }
        }

        public void Begin()
        {
            foreach (var item in directions)
            {
                switch (Direction)
                {
                    case Directions.N:
                        item.DirectToNorth();
                        break;
                    case Directions.S:
                        item.DirectToSouth();
                        break;
                    case Directions.E:
                        item.DirectEast();
                        break;
                    case Directions.W:
                        item.DirectWest();
                        break;
                    default:
                        break;
                }

                this.ValidationPosition();
            }
        }

        public void End()
        {
            Console.WriteLine($" Position current ({this.X}, {Y}) {Direction}");
        }

        public void Clear()
        {
            this.directions.Clear();
        }
    }
}