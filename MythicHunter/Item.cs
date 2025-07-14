using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicHunter
{
    public class Item
    {
        private string name;
        private int bonusPower;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int BonusPower
        {
            get
            {
                return this.bonusPower;
            }
            set 
            {
                this.bonusPower = value;
            }
        }
    }
}
