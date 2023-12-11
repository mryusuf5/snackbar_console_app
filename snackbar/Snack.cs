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

        public string Name { get { return _name; } }

        private readonly decimal _price;

        private int _amountInStock;
        public int AmountInStock { get { return _amountInStock; } }

        public Snack(string name = "", decimal price = 0, int amountInStock = 0)
        {
            this._name = !string.IsNullOrEmpty(name) ? name : throw new ArgumentException("Provide valid snack name");
            this._price = price > 0 ? price : throw new ArgumentException("Provide a valid price for snack");
            this._amountInStock = amountInStock;
        }

        public string DisplaySnack()
        {
            return $"Name of snack is {this._name}. It costs €{this._price}. There is still {this._amountInStock} in stock.";
        }

        public decimal TotalPrice(int amount)
        {
            return amount * this._price;
        }

        public bool IsInStock(int amount)
        {
            return this._amountInStock >= amount;
        }

        public void UpdateStock(int amount)
        {
            if(amount <= _amountInStock)
            {
                _amountInStock -= amount;
            }
        }
    }
}
