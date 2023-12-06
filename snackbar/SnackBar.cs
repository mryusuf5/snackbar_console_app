using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snackbar
{
    internal class SnackBar
    {
        private readonly List<Snack> _snacks;
        private double _totalRevenue;

        public SnackBar(List<Snack> snacks, double totalRevenue)
        {
            _snacks = snacks;
            _totalRevenue = totalRevenue;
        }

        public void UpdateTotalRevenue(double[] orderPrices)
        {
            _totalRevenue += orderPrices.Sum();
        }

        public double GetTotalRevenue()
        {
            return _totalRevenue;
        }

        public List<Snack> GetSnacks()
        {
            return _snacks;
        }
    }
}
