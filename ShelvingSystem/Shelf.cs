using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelvingSystem
{
    internal class Shelf
    {
        Good?[,] goods;
        public Shelf(int rows, int columns)
        {
            goods = new Good[rows, columns];
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

                for (int column = 0; column < goods.GetLength(1); column++)
                {
                    if (goods[row, column] == null)
                    {
                        Console.Write($"|   ");
                    }
                    else
                    {
                        Console.Write($"| {goods[row, column].Kurzzeichen()} ");
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
        public double Utilization()
        {
            return (double)GetFullSpaces() / (double)GetAmountOfSpaces()*100;
        }
        public Good? DeliverGood(int row, int column)
        {
            Good? good = goods[row, column];
            goods[row, column] = null;
            return good;
        }
        public void StoreGood(int row, int column, Good newGood)
        {
            if (goods[row, column] is not Good oldGood)
            {
                goods[row, column] = newGood;
                return;
            }
            Console.WriteLine($"Space {row}/{column} occupied --> {oldGood.Description()}");

        }
        public void StoreGood( Good newGood)
        {
            if (GetAmountOfSpaces == GetFullSpaces)
            {
                Console.WriteLine("No Empty Spaces!");
            }
            for(int row = 0; row < goods.GetLength(0); row++)
            {
                for(int column = 0; column < goods.GetLength(1); column++)
                {
                    if (goods[row,column]is not null)
                    {
                        continue;
                    }
                    goods[row, column] = newGood;
                    return;
                }
            }
        }


        private int GetAmountOfSpaces()
        {
            return goods.GetLength(0) * goods.GetLength(1);
        }

        private int GetFullSpaces()
        {
            int count = 0;
            for (int row = 0; row < goods.GetLength(0); row++)
            {
                for (int column = 0; column < goods.GetLength(1); column++)
                {
                    if (goods[row, column] != null) count++;
                }
            }
            return count;
        }
    }
}
