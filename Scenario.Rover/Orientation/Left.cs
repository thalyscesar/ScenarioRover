using Scenario.Rover.Enums;
using Scenario.Rover.Interfaces;

namespace Scenario.Rover.Orientation
{
    public class Left : IDirection
    {
        private Position _position;

        public Left(Position position)
        {
            _position = position;
        }

        public void DirectEast()
        {
            _position.Direction = Directions.N;
        }

        public void DirectToNorth()
        {
            _position.Direction = Directions.W;
        }

        public void DirectWest()
        {
            _position.Direction = Directions.S;
        }

        public void DirectToSouth()
        {
            _position.Direction = Directions.E;
        }
    }
}