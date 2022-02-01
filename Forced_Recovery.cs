using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Forced_Recovery:Skill
    {
        public void Use_Skills(Hero AttackerHero, Hero TargetrHero)
        {
            AttackerHero.Strength = AttackerHero.Strength * 7 / 10;//力量消弱
            AttackerHero.Hp = AttackerHero.Hp + AttackerHero.Strength * 5 / 10;//生命值回復力量*1/2
            Console.WriteLine(AttackerHero.Name + "回復" + AttackerHero.Strength * 5 / 10  + "HP");//顯示回復數值
        }
    }
}
