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
            Shelf shelf = new Shelf(5, 10);
            
            shelf.Show();
        }
    }
}
