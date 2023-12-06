using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snackbar
{
    internal class Snack
    {
        private readonly string _name;
        private readonly double _price;
        private int _amountInStock;

        public Snack(string name = "", double price = 0, int amountInStock = 0)
        {
            this._name = name;
            this._price = price;
            this._amountInStock = amountInStock;
        }

        public string Display()
        {
            return $"Name of snack is {this._name}. It costs {this._price}. There is still {this._amountInStock} in stock.";
        }

        public int UpdateStock(int amount)
        {
            return this._amountInStock -= amount;
        }

        public double TotalPrice(int amount)
        {
            return amount * this._price;
        }

        public bool CheckStock(int amount)
        {
            return this._amountInStock >= amount;
        }

        public int GetStock()
        {
            return this._amountInStock;
        }
    }
}
