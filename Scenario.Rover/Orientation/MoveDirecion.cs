using Scenario.Rover.Interfaces;

namespace Scenario.Rover.Orientation
{
    public class MoveDirecion : IDirection
    {
        private Position _position;

        public MoveDirecion(Position position)
        {
            _position = position;
        }

        public void DirectToNorth()
        {
            this._position.Y += 1;
        }

        public void DirectToSouth()
        {
            this._position.Y -= 1;
        }

        public void DirectEast()
        {
            this._position.X += 1;
        }

        public void DirectWest()
        {
            this._position.X -= 1;
        }
    }
}