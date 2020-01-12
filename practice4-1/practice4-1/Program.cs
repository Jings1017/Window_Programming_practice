using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice4_1
{
    class Program
    {
        static public string[] SaberS = { "Lancer", "Berserker" };
        static public string[] SaberW = { "Archer" };
        static public string[] ArcherS = { "Saber", "Berserker" };
        static public string[] ArcherW = { "Lancer" };
        static public string[] LancerS = { "Archer", "Berserker" };
        static public string[] LancerW = { "Saber" };
        static public string[] RiderS = { "Caster", "Berserker" };
        static public string[] RiderW = { "Assassin" };
        static public string[] CasterS = { "Assassin", "Berserker" };
        static public string[] CasterW = { "Rider" };
        static public string[] AssassinS = { "Rider", "Berserker" };
        static public string[] AssassinW = { "Caster" };
        static public string[] BerserkerS = { "Saber", "Archer","Lancer","Rider","Caster","Assassin"};
        static public string[] BerserkerW = { };

        static public Character randomCharacter(int ch)
        {
            
            switch (ch)
            {
                case 1:
                    return new Character("Saber",SaberS,SaberW,100,50,1,1);
                case 2:
                    return new Character("Archer", ArcherS, ArcherW, 50, 100, 0.95, 0.5);
                case 3:
                    return new Character("Lancer", LancerS, LancerW, 75, 75, 1.05, 0.75);
                case 4:
                    return new Character("Rider", RiderS, RiderW, 150, 50, 1, 0.8);
                case 5:
                    return new Character("Caster", CasterS, CasterW, 200, 25, 0.9, 1);
                case 6:
                    return new Character("Assassin", BerserkerS, BerserkerW, 50, 100, 0.9, 1);
                case 7:
                    return new Character("Berserker", BerserkerS, BerserkerW, 60, 100, 1.1, 1);
                default:
                    return new Character("Berserker", BerserkerS, BerserkerW, 60, 100, 1.1, 1);
            }
        }

        static void Main(string[] args)
        {
            int r1 = 0, r2 = 0;
            double my_tmp =0,enemy_tmp=0;
            bool cont = false;
            Console.Write("輸入y來開始遊戲,n退出遊戲:");

            while (true)
            {
                
                string input = Console.ReadLine();
                if (input == "y" )
                {
                    if (cont == false)
                    {
                        Random rand = new Random();
                        r1 = rand.Next(1, 8);
                        r2 = rand.Next(1, 8);
                        
                    }

                    Character myself = randomCharacter(r1);
                    Character enemy = randomCharacter(r2);

                    double my_before = myself.getHealth();
                    double enemy_before = enemy.getHealth();
                    if (cont == true)
                    {
                        my_before = my_tmp;
                        enemy_before = enemy_tmp;
                    }
                    double my_later = my_before - enemy.attackWithRatio(myself.getType());
                    double enemy_later = enemy_before  -myself.attackWithRatio(enemy.getType());

                    Console.WriteLine("您的角色為"+ myself.getType() +"，此回合前血量"+ my_before+"，攻擊對方"+ myself.attackWithRatio(enemy.getType()) + "，此回合後血量"+ my_later+"\n");
                    Console.WriteLine("敵人角色為" + enemy.getType() + "，此回合前血量" + enemy_before + "，攻擊對方" + enemy.attackWithRatio(myself.getType()) + "，此回合後血量" + enemy_later + "\n");


                    if (my_later > 0 && enemy_later <= 0)
                    {
                        Console.WriteLine("敵人倒下，此回合獲勝，輸入y來繼續遊戲，n退出遊戲:");
                        cont = false;
                    }
                    else if (my_later <= 0)
                    {
                        Console.WriteLine("您已死亡，輸入y來重新遊戲，n退出遊戲:");
                        cont = false;
                    }
                    else if(my_later >0 && enemy_later >0)
                    {
                        Console.WriteLine("雙方均存活，輸入y來繼續下一回合，n退出遊戲:");
                        cont = true;
                        my_tmp = my_later;
                        enemy_tmp = enemy_later;
                    }

                }
                else if(input == "n")
                {
                    break;
                }
            }
            Console.Read();
        }
    }
}
