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

        public IReadOnlyList<Snack> Snacks => _snacks.AsReadOnly();

        private decimal _totalRevenue;

        public decimal TotalRevenue { get { return _totalRevenue; } }

        public SnackBar(List<Snack> snacks, decimal totalRevenue)
        {
            _snacks = snacks;
            _totalRevenue = totalRevenue;
        }

        public void UpdateTotalRevenue(decimal[] orderPrices)
        {
            _totalRevenue += orderPrices.Sum();
        }
    }
}
