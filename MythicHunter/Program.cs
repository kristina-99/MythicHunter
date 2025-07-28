using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicHunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;

            char[,] map = GenerateMap();

            Hero myHero = new Hero();

            map[myHero.CurrentYPosition, myHero.CurrentXPosition] = 'H';

            while (!gameOver)
            {
                PrintMap(map);
           
                Console.WriteLine("Please enter the next direction (w, a, s or d):");
                string userInput = Console.ReadLine();

                map[myHero.CurrentYPosition,myHero.CurrentXPosition] = '.';

                myHero.Move(userInput[0]);

                map[myHero.CurrentYPosition,myHero.CurrentXPosition] = 'H';

                Console.Clear();
            }
        }

        static void PrintMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

        static char[,] GenerateMap()
        {
            char[,] map = new char[4,6];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i,j] = '.';
                }
            }

            map[2, 2] = '#';
            map[2, 4] = '#';
            map[2, 5] = '#';
            map[3, 2] = '#';

            Random rng = new Random();

            int monsterY = rng.Next(1, 3);
            int monsterX = rng.Next(1, 5);

            map[monsterY, monsterX] = 'M';

            int itemY = rng.Next(1, 3);
            int itemX = rng.Next(1, 5);

            if (itemY != monsterY && itemX != monsterX)
            {
                map[itemY, itemX] = 'I';
            }
            else
            {
                while (itemY == monsterY || itemX == monsterX)
                {
                    itemY = rng.Next(1, 3);
                    itemX = rng.Next(1, 5);
                }

                map[itemY, itemX] = 'I';
            }

            return map;
        }
    }
}
