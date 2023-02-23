using Scenario.Rover.Enums;

namespace Scenario.Rover.Interfaces
{
    public interface IPosition
    {
        int X { get; set; }
        int Y { get; set; }
        int MaximoX { get; set; }
        int MaximoY { get; set; }
        Directions Direction { get; set; }
        void Load(string moves);
        void Begin();
        void End();
        void Clear();
    }
}
