using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Robot
{
    class SmartRobot : Robots
    {
        public SmartRobot(string name_hero, string hero)
            : base(name_hero, hero)
        {
            legend = "  Smart - Очень умный робот, точная дата создание неизвестна, его нашли на космическом корабле, упавшего с неба.\n  Предназначение робота неизвестно , он справляется со всеми поставлеными задачами.\n  Предназначен для небольшой нагрузке ,наверное гравитация на планете откуда он прибыл - мала :( \n  При обнаружении у него была повреждена батарея, которую пришлось заменить\n  +  Может декодировать груз в 100% случаев\n  -  Имеет слабую батарею\n  -  Плохая грузоподъемность\n\n";
            battery = 550;
            carrying = 160;
            chanceDecoding = 100;
            overload = 0;
            overloadBattery = 0;
            fullHero = "Smart";
        }

       

    }
}
