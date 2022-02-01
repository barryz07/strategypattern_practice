using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero_A = new Hero("Jack",new fire_punch(), new Forced_Recovery());
            Hero hero_B = new Hero("Alen", new Lightningbolt(), new Forced_Recovery());

            Battle battle = new Battle(hero_A, hero_B);
            battle.start();
        }
    }
}
