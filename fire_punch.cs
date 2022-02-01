using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class fire_punch:Skill
    {
        public void Use_Skills(Hero AttackerHero, Hero TargetrHero)
        {
            int injury = AttackerHero.Strength - TargetrHero.Defense;//計算傷害值
            TargetrHero.Losthp(injury);
            Console.WriteLine(AttackerHero.Name + "造成" + TargetrHero.Name + injury + "傷害");//印出傷害顯示
            
        }
    }
}
