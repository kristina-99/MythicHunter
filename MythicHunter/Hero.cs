using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicHunter
{
    public class Hero
    {
        private int power;
        private int mana;
        private int health;
        private List<string> inventory;
        private int currentXposition;
        private int currentYposition;

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

        public void addItemToInventory(string newItem)
        {
            inventory.Add(newItem);
        }

        public void Move(char inputKey)
        {
            switch (inputKey)
            {
                case 'w':
                    {
                        if (currentYposition < 3)
                        {
                            currentYposition++;
                        }
                        else
                        {
                            Console.WriteLine("The hero can't leave the map. Please move to another direction!");
                        }
                        break;
                    }
                case 's':
                    {
                        if (currentYposition > 0)
                        {
                            currentYposition--;
                        }
                        else
                        {
                            Console.WriteLine("The hero can't leave the map. Please move to another direction!");
                        }
                        break;
                    }
                case 'd':
                    {
                        if (currentYposition < 5)
                        {
                            currentXposition++;
                        }
                        else
                        {
                            Console.WriteLine("The hero can't leave the map. Please move to another direction!");
                        }
                        break;
                    }
                case 'a':
                    {
                        if (currentYposition > 0)
                        {
                            currentXposition--;
                        }
                        else
                        {
                            Console.WriteLine("The hero can't leave the map. Please move to another direction!");
                        }
                        break;
                    }
            }
        }
    }
}
