using snackbar;

Snack[] snack = new Snack[3];

snack[0]  = new Snack("frikandel", 1.50, 10);
snack[1] = new Snack("kaaskroket", 1, 10);
snack[2] = new Snack("loempia", 3.50, 10);

double[] orderPrices = new double[3];
double totalRevenue = 0;
bool ordering = true;

int snackNumber = 0;

SnackBar snackbar = new SnackBar(snack[0], snack[1], snack[2]);

while(ordering)
{
    Console.WriteLine($"how many of snack number {snackNumber} do you want? \n");
    string input = Console.ReadLine();
    
    if(snack[snackNumber].checkStock(Convert.ToInt32(input)))
    {
        snack[snackNumber].updateStock(Convert.ToInt32(input));
        orderPrices[snackNumber] = snack[snackNumber].totalPrice(Convert.ToInt32(input));
        Console.WriteLine(snack[snackNumber].totalPrice(Convert.ToInt32(input)));

        Console.WriteLine($"you have chosen {input} of snack number {snackNumber}, {snack[snackNumber].display()} \n");

        snackNumber++;

        if (snackNumber == 3)
        {
            totalRevenue += snackbar.calculateTotalRevenue(orderPrices[0], orderPrices[1], orderPrices[2]);
            Console.WriteLine(snackbar.calculateTotalRevenue(orderPrices[0], orderPrices[1], orderPrices[2]));
            Console.WriteLine($"your total revenue is {totalRevenue} \n");
            Console.WriteLine("\n \n \n");
            Console.WriteLine("Do you want to keep ordering? (Y or N)\n");
            string keepOrdering = Console.ReadLine();
            ordering = keepOrdering is "Y" or "y";
            snackNumber = 0;
        }
    }
    else
    {
        Console.WriteLine($"We dont have enough in stock, all we have is {snack[snackNumber].getStock()}\n");
    }
}
