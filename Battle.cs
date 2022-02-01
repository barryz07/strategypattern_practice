using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Battle
    {
        Hero[] heroes= new Hero[2];
        

        public Battle(Hero hero_A, Hero hero_B)
        {
            heroes[0] = hero_A;
            heroes[1] = hero_B;
        }

        public void start()
        {
            int turn=0;   //回和輪換變數
            Console.WriteLine("遊戲開始\n");
            
            while (!isGameOver())
            {
               
               Console.WriteLine("輪到" + heroes[turn].Name + "的回合，請輸入技能指令"); 
               char instruction = Char.Parse(Console.ReadLine());//輸入技能變數
               ProcessHeroTurn(instruction,turn);//執行技能
               turn = (turn == 0 ? 1 : 0);//攻守交換
               

            }
            Console.WriteLine("勝利者為" + heroes[turn].Name);
        }

        

        private void ProcessHeroTurn(char instruction, int heroIndex)
        {
            Hero AttackerHero = heroes[heroIndex];//設定攻擊方
            Hero TargetrHero = heroes[heroIndex == 0 ? 1 : 0];//設定目標方
            AttackerHero.Use_Skills(instruction,TargetrHero);//攻擊方執行技能
            Console.WriteLine( heroes[0].Name+"的hp: "+ heroes[0].Hp);
            Console.WriteLine(heroes[1].Name + "的hp: " + heroes[1].Hp);
        }

        private bool isGameOver()
        {
            if (heroes[0].Hp <= 0 || heroes[1].Hp <= 0)
            {
                return true;
            } 
            return false;

        }

    }
}
