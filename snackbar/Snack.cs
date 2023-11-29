using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snackbar
{
    internal class Snack
    {
        private string name;
        private double price;
        private int amountInStock;

        public Snack(string name = "", double price = 0, int amountInStock = 0)
        {
            this.name = name;
            this.price = price;
            this.amountInStock = amountInStock;
        }

        public string display()
        {
            return $"Name of snack is {this.name}. It costs {this.price}. There is still {this.amountInStock} in stock.";
        }

        public int updateStock(int amount)
        {
            return this.amountInStock -= amount;
        }

        public double totalPrice(int amount)
        {
            return amount * this.price;
        }

        public bool checkStock(int amount)
        {
            return this.amountInStock >= amount ? true : false;
        }

        public int getStock()
        {
            return this.amountInStock;
        }
    }
}
