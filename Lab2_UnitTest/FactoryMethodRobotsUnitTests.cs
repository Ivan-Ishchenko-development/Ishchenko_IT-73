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

            Assert.AreEqual(robot.legend, "  Working - ������������� ����� , ��� ������ ��� � ���� , �� ����� ��� ��������� � ����� � ����������� \n   ��������� �� ����� ������ \n  + ����� ������� �������\n  + �������� ����������������\n  - ����� ������������ ���� � 10% �������");
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

            Assert.AreEqual(robot.legend, "  Smart - ����� ����� �����, ������ ���� �������� ����������, ��� ����� �� ����������� �������, �������� � ����.\n  �������������� ������ ���������� , �� ����������� �� ����� ������������ ��������.\n  ������������ ��� ��������� �������� ,�������� ���������� �� ������� ������ �� ������ - ���� :( \n  ��� ����������� � ���� ���� ���������� �������, ������� �������� ��������\n  +  ����� ������������ ���� � 100% �������\n  -  ����� ������ �������\n  -  ������ ����������������\n\n");
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

            Assert.AreEqual(robot.legend, "\n\n  Cyborg - ������ �� ������ ����� ��������� � 2031 ����, ��������� ����������.\n  ��� ������������ ��� ������ ������ �� ����.\n  +  ����� ������������ ���� � 60% �������\n  +  ����� ������� �������\n  -  ����� �������� ���� ������� �� ��������� ����\n  -  ��� ���������� �������� �� 80% ������� ���������������� ������ ������ � ����� ���� ������� � 30% �������\n\n");
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
