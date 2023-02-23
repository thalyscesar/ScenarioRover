using MarsRoverProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Scenario.Rover.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PositionRover1_OK()
        {
            //Arrange
            Position p = new Position()
            {
                MaximoX = 5,
                MaximoY = 5,
                X = 1,
                Y = 2,
                Direction = Directions.N,
            };
            string moves = "LMLMLMLMM";

            //Action
            p.Load(moves);
            p.Begin();
            p.End();

            //Asserts
            Assert.AreEqual(1, p.X);
            Assert.AreEqual(3, p.Y);
            Assert.AreEqual(Directions.N, p.Direction);


        }

        [TestMethod]
        public void PositionRover2_OK()
        {
            //Arrange
            Position p = new Position()
            {
                MaximoX = 5,
                MaximoY = 5,
                X = 3,
                Y = 3,
                Direction = Directions.E,
            };
            string moves = "MMRMMRMRRM";

            //Action
            p.Load(moves);
            p.Begin();
            p.End();
            p.Clear();

            //Asserts
            Assert.AreEqual(5, p.X);
            Assert.AreEqual(1, p.Y);
            Assert.AreEqual(Directions.E, p.Direction);
        }

        [TestMethod]
        public void PositionRover1_Error_LimitExceed()
        {
            //Arrange
            Position p = new Position()
            {
                MaximoX = 5,
                MaximoY = 5,
                X = 3,
                Y = 3,
                Direction = Directions.E,
            };

            string moves = "MMRMMRMRRMMMRMMRMMM";

            //Action
            p.Load(moves);

            //Assert
            Assert.ThrowsException<Exception>(() => p.Begin());
        }
    }
}
