using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2_.Robot;

namespace Lab2_UnitTest
{
    [TestClass]
    public class FactoryMethodRobotsUnitTests
    {
        
        public Robots CreateWorkingRobot()
        {
            return new WorkingCreator().Create();
        }
        public Robots CreateCyborgRobot()
        {
            return new CyborgCreator().Create();
        }
        public Robots CreateSmartRobot()
        {
            return new SmartCreator().Create();
        }


        [TestMethod]
        public void WorkingStats()
        {
            
            var robot = CreateWorkingRobot();

            Assert.AreEqual(robot.legend, "  Working - Малоспособный робот , был создан еще в СССР , но много раз переделан в связи с постоянными \n   поломками во время работы \n  + Имеет хорошую батарею\n  + Отличная грузоподъемность\n  - Может декодировать груз в 10% случаев");
            Assert.AreEqual(robot.battery, 1000);
            Assert.AreEqual(robot.carrying, 200);
            Assert.AreEqual(robot.chanceDecoding, 10);
            Assert.AreEqual(robot.overload, 0);
            Assert.AreEqual(robot.overloadBattery, 0);
            Assert.AreEqual(robot.fullHero, "Working");
            Assert.AreEqual(robot.hero, "W");

            
        }

        [TestMethod]
        public void SmartStats()
        {
            var robot = CreateSmartRobot();

            Assert.AreEqual(robot.legend, "  Smart - Очень умный робот, точная дата создание неизвестна, его нашли на космическом корабле, упавшего с неба.\n  Предназначение робота неизвестно , он справляется со всеми поставлеными задачами.\n  Предназначен для небольшой нагрузке ,наверное гравитация на планете откуда он прибыл - мала :( \n  При обнаружении у него была повреждена батарея, которую пришлось заменить\n  +  Может декодировать груз в 100% случаев\n  -  Имеет слабую батарею\n  -  Плохая грузоподъемность\n\n");
            Assert.AreEqual(robot.battery, 550);
            Assert.AreEqual(robot.carrying, 160);
            Assert.AreEqual(robot.chanceDecoding, 100);
            Assert.AreEqual(robot.overload, 0);
            Assert.AreEqual(robot.overloadBattery, 0);
            Assert.AreEqual(robot.fullHero, "Smart");
            Assert.AreEqual(robot.hero, "S");


        }

        [TestMethod]
        public void CyborgStats()
        {
            var robot = CreateCyborgRobot();

            Assert.AreEqual(robot.legend, "\n\n  Cyborg - Весьма не плохой робот созданный в 2031 году, японскими инженерами.\n  Был предназначен для легкой работы на дому.\n  +  Может декодировать груз в 60% случаев\n  +  Имеет хорошую батарею\n  -  Может обжечься если попадет на токсичный груз\n  -  При длительной нагрузке до 80% средней грузоподъемности киборг болеет и садит свою батарею в 30% случаем\n\n");
            Assert.AreEqual(robot.battery, 800);
            Assert.AreEqual(robot.carrying, 180);
            Assert.AreEqual(robot.chanceDecoding, 60);
            Assert.AreEqual(robot.overload, 80);
            Assert.AreEqual(robot.overloadBattery, 30);
            Assert.AreEqual(robot.fullHero, "Cyborg");
            Assert.AreEqual(robot.hero, "C");


        }
    }
}
