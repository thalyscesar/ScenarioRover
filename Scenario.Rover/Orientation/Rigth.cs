using Scenario.Rover.Enums;
using Scenario.Rover.Interfaces;

namespace Scenario.Rover.Orientation
{
    public class Rigth : IDirection
    {
        private Position _position;

        public Rigth(Position position)
        {
            _position = position;
        }

        public void DirectEast()
        {

            this._position.Direction = Directions.S;
        }

        public void DirectToNorth()
        {
            this._position.Direction = Directions.E;
        }

        public void DirectWest()
        {
            this._position.Direction = Directions.N;
        }

        public void DirectToSouth()
        {
            this._position.Direction = Directions.W;
        }
    }
}