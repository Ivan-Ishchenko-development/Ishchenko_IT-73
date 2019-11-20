using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_.Robot
{
    class CyborgRopot : Robots
    {
        public CyborgRopot(string name_hero, string hero)
            : base(name_hero, hero)
        {
            legend = "\n\n  Cyber - Весьма не плохой робот созданный в 2031 году, японскими инженерами.\n  Был предназначен для легкой работы на дому.\n  +  Может декодировать груз в 60% случаев\n  +  Имеет хорошую батарею\n  -  Может обжечься если попадет на токсичный груз\n  -  При длительной нагрузке до 80% средней грузоподъемности киборг болеет и садит свою батарею в 30% случаем\n\n";
            battery = 800;
            carrying = 180;
            chanceDecoding = 60;
            overload = 80;
            overloadBattery = 30;
            fullHero = "Cyborg";
        }

    }
}
