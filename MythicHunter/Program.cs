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

            char[][] map = new char[][]
            {
                new char[]{ '.', '.', '.', '.', '.', '.'},
                new char[]{ '.', '.', 'M', '.', '.', '.'},
                new char[]{ '.', '.', '#', '.', '#', '#'},
                new char[]{ '.', 'I', '#', '.', '.', '.'}
            };

            Hero myHero = new Hero();

            map[myHero.CurrentXPosition][myHero.CurrentXPosition] = 'H';

            while (!gameOver)
            {
                for (int i = 0; i < map.Length; i++)
                {
                    for (int j = 0; j < map[i].Length; j++)
                    {
                        Console.Write(map[i][j]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Please enter the next direction (W, A, S or D):");
            }
        }
    }
}
