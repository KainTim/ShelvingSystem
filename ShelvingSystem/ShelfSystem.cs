using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelvingSystem
{
    internal class ShelfSystem
    {
        public static void Main() 
        {
            Shelf shelf = new Shelf(5, 5);
            
            shelf.StoreGood(new Book(1, 15, 12, 3));
            shelf.StoreGood(new Book(2, 12, 23, 5));
            shelf.StoreGood(new Book(3, 16, 21, 2));
            shelf.StoreGood(new Book(4, 14, 22, 1));
            shelf.StoreGood(1, 0, new Tool(5, 12.5));
            shelf.StoreGood(1, 1, new Tool(5, 12.5));
            shelf.StoreGood(1, 2, new Tool(5, 12.5));
            shelf.Show();
            Console.WriteLine("Utilization: {0:0.##}%",shelf.Utilization());
        }
    }
}
