using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2_.Robot;
using Lab2_.State;
using Lab2_;

namespace Lab2_UnitTest
{
    [TestClass]
    public class GamePoleUnitTests
    {
        public string name { get; private set; } = "Sergey";
        public Game game;
       // public GamePole pole;
        [TestInitialize]
        public void TestInitialize()
        {
            
            Robots Robot = new WorkingCreator().Create();
          
        }

        [TestMethod]
        public void RenderGamePoleTest()
        {
            
            int r = 20; // Количество  столбцов
            int s = 30; // Количество  рядов

            

        }
    }
}
