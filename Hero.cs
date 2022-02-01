using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Hero
    {
        private string name;    //英雄名稱
        private int hp=100;     //生命值
        private int mp=20;     //魔力值
        private int strength=25;     //力量
        private int wisdom=15;     //智力
        private int defense=5;     //防禦力
        private Skill q_skill;  
        private Skill z_skill;
        
        public Hero (string name , Skill q_skill, Skill z_skill)//建構子
        {
            this.name = name;
            this.q_skill = q_skill;
            this.z_skill = z_skill;
        }
        public  string Name
        {
            get => name;
            set => name = value ;
        }
        public  int Hp
        {
            get => hp;
            set => hp = value;
        }
        public int Mp
        {
            get =>mp;
            set => mp = value;
        }
        public int Strength
        {
            get => strength;
            set => strength = value;
        }
        public int Wisdom
        {
            get => wisdom;
            set => wisdom = value;
        }
        public int Defense
        {
            get => defense;
            set => defense = value;
        }
        public void Losthp(int injury)
        {
            hp = hp - injury;
        }
        public void Use_Skills(char instruction, Hero target){
            switch (instruction)
            {
                case 'q':
                    q_skill.Use_Skills(this, target);
                    break;
                case 'z':
                    z_skill.Use_Skills(this, target);
                    break;
                default:
                    Console.WriteLine("欸認真回答啦");
                    break;
            }
            
        }
    }
}
