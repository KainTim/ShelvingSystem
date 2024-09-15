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

            Console.WriteLine("\n\nTest Method: ");
            TestCsv();
        }
        public static void TestCsv()
        {
            Shelf shelf = new Shelf(6, 5);

            string[] lines = File.ReadAllLines("105a_waren.csv");
            for (int i = 0; i < lines.GetLength(0); i++)
            {
                string[] parts = lines[i].Split(";");
                if (parts[0].Equals("Werkzeug"))
                {
                    shelf.StoreGood(int.Parse(parts[1]), int.Parse(parts[2]),
                        new Tool(int.Parse(parts[3]), double.Parse(parts[4])));
                }
                else
                {
                    shelf.StoreGood(int.Parse(parts[1]), int.Parse(parts[2]),
                        new Book(int.Parse(parts[3]), int.Parse(parts[4]),
                        int.Parse(parts[5]), int.Parse(parts[6])));
                }
            }
            shelf.Show();
            Console.WriteLine("Utilization: {0:0.##}%", shelf.Utilization());
        }
    }
}
