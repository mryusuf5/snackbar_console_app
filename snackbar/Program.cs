using snackbar;

List<Snack> snacks = new List<Snack>
{
    new Snack("frikandel", 1.50, 10),
    new Snack("kaaskroket", 1.00, 10),
    new Snack("loempia", 3.50, 10)
};

double[] orderPrices = new double[snacks.Count];
bool ordering = true;

int snackIndex = 0;

SnackBar snackbar = new SnackBar(snacks, 0);

while (ordering)
{
    Console.WriteLine($"How many of snack number {snackIndex} do you want?\n");
    int userQuantity = GetValidQuantityInput();

    if (snacks[snackIndex].CheckStock(userQuantity))
    {
        snacks[snackIndex].UpdateStock(userQuantity);
        orderPrices[snackIndex] = snacks[snackIndex].TotalPrice(userQuantity);
        Console.WriteLine(snacks[snackIndex].TotalPrice(userQuantity));

        Console.WriteLine($"You have chosen {userQuantity} of snack number {snackIndex}, {snacks[snackIndex].Display()}\n");

        snackIndex++;

        if (snackIndex == snacks.Count)
        {
            snackbar.UpdateTotalRevenue(orderPrices);
            Console.WriteLine(snackbar.GetTotalRevenue());
            Console.WriteLine($"Your total revenue is {snackbar.GetTotalRevenue()}\n");
            Console.WriteLine("\n \n \n");
            Console.WriteLine("Do you want to keep ordering? (Y or N)\n");
            string keepOrdering = Console.ReadLine()!;
            ordering = keepOrdering is "Y" or "y";;
            snackIndex = 0;
        }
    }
    else
    {
        Console.WriteLine($"We don't have enough in stock. All we have is {snacks[snackIndex].GetStock()}\n");
    }
    
}


int GetValidQuantityInput()
{
    while (true)
    {
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out int quantity) && quantity > 0)
        {
            return quantity;
        }

        Console.WriteLine("Invalid input. Please enter a valid positive number.\n");
    }
}