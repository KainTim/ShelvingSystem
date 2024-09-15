using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelvingSystem
{
    internal class Shelf
    {
        Good[,] goods;
        public Shelf(int rows, int columns) 
        {
            goods=new Good[rows,columns];
        }
        public void Show()
        {
            for (int row = 0; row < goods.GetLength(0); row++)
            {
                for (int i = 0; i < goods.GetLength(1); i++)
                {
                    Console.Write("----");
                }
                Console.WriteLine("-");

                for(int column = 0; column < goods.GetLength(1); column++)
                {
                    if (goods[row, column] == null)
                    {
                        Console.Write($"|   ");
                    }
                    else
                    {
                        Console.Write($"| {goods[row, column]} ");
                    }
                }
                Console.WriteLine("|");
            }
            for (int i = 0; i < goods.GetLength(1); i++)
            {
                Console.Write("----");
            }
            Console.WriteLine("-");
        }
    }
}
