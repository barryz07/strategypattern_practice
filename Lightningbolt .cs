using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Lightningbolt : Skill
    {
        public void Use_Skills(Hero AttackerHero, Hero TargetrHero)
        {
            int injury = (AttackerHero.Mp*3)/2 - TargetrHero.Defense;//
            TargetrHero.Losthp(injury);
            Console.WriteLine(AttackerHero.Name + "造成" + TargetrHero.Name + injury + "傷害");

        }
    }
}
