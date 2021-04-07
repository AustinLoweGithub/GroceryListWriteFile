using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryItems
{
    public class Groceries
    {
        public string item { get; set; }
        public double quantity { get; set; }

        public double price { get; set; }

        public double totalcost { get; set; }

        public Groceries(string _item, double _quantity, double _price)
        {
            item = _item;

            quantity = _quantity;

            price = _price;

            totalcost = Math.Round((_price * _quantity), 2);

        }


    }
}