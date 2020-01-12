using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice4_1
{
    class Character
    {
        protected string Type;
        protected string[] typesStrongTo;
        protected string[] typesWeakTo;
        protected double health;
        protected double attack;
        protected double attackBuff;
        protected double hitRate;

        public Character(string Type, string[] typesStrongTo, string[] typesWeakTo, double health, double attack, double attackBuff, double hitRate)
        {
            this.Type = Type;
            this.typesStrongTo = typesStrongTo;
            this.typesWeakTo = typesWeakTo;
            this.health = health;
            this.attack = attack;
            this.attackBuff = attackBuff;
            this.hitRate = hitRate;
        }

        public double attackWithRatio(string enemyType)
        {
            Random ran = new Random();
            if (ran.NextDouble() > this.hitRate)
            {
                return 0;
            }
            else if(typesStrongTo.Contains(enemyType))
            {
                return attack * 2 * attackBuff;
            }
            else if (typesWeakTo.Contains(enemyType))
            {
                return attack * 0.5 * attackBuff;
            }
            else
            {
                return attack * attackBuff;
            }
        }

        public string getType()
        {
            return Type;
        }

        public double getHealth()
        {
            return health;
        }
        public void setHealth(double _health)
        {
            health = _health;
        }

    }
}
