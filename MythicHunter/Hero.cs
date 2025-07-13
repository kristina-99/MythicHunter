using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicHunter
{
    internal class Hero
    {
        private int power;
        private int mana;
        private int health;

        public int Power 
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }

        public int Mana
        {
            get
            {
                return this.mana;
            }
            set
            {
                this.mana = value;
            }
        }

        public int Health
        {
            get 
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }
    }
}
