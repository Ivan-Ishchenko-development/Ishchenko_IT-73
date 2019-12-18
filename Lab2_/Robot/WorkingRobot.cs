using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Robot
{
    public class WorkingRobot : Robots
    {

        public WorkingRobot(string hero)
            : base(hero)
        {
            legend = "  Working - Малоспособный робот , был создан еще в СССР , но много раз переделан в связи с постоянными \n   поломками во время работы \n  + Имеет хорошую батарею\n  + Отличная грузоподъемность\n  - Может декодировать груз в 10% случаев";
            battery = 1000;
            carrying = 200;
            chanceDecoding = 10;
            overload = 0;
            overloadBattery = 0;
            fullHero = "Working";
        }

        public WorkingCreator WorkingCreator
        {
            get => default;
            set
            {
            }
        }
    }
}
