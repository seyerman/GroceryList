using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryList.Model
{
    class GroceryList
    {
        public List<Item> Items { get; }

        public GroceryList()
        {
            Items = new List<Item>();
        }
    }
}
