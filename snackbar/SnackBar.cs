using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snackbar
{
    internal class SnackBar
    {
        Snack snack1 = new Snack();
        Snack snack2 = new Snack();
        Snack snack3 = new Snack();

        //private double[] totalRevenue;
        private double totalRevenue;

        public SnackBar(Snack snack1, Snack snack2, Snack snack3)
        {
            this.snack1 = snack1;
            this.snack2 = snack2;
            this.snack3 = snack3;
        }

        public double calculateTotalRevenue(double totalPriceSnack1, double totalPriceSnack2, double totalPriceSnack3)
        {
            return this.totalRevenue + (totalPriceSnack1 + totalPriceSnack2 + totalPriceSnack3);
        }
    }
}
