using snackbar;

List<Snack> snacks = new List<Snack>
{
    new Snack("frikandel", 1.50m, 10),
    new Snack("kaaskroket", 2.50m, 10),
    new Snack("loempia", 4.50m, 10)
};

decimal[] orderPrices = new decimal[snacks.Count];
bool takingOrder = true;

int snackIndex = 0;

SnackBar snackbar = new SnackBar(snacks, 0);

while (takingOrder)
{
    var snack = snacks[snackIndex];
    Console.WriteLine($"How many of {snack.Name} do you want?\n");

    int userQuantity = GetValidQuantityInput();
   

    if (snack.IsInStock(userQuantity))
    {
        snack.UpdateStock(userQuantity);
        orderPrices[snackIndex] = snack.TotalPrice(userQuantity);
        Console.WriteLine(orderPrices[snackIndex]);

        Console.WriteLine($"You have chosen {userQuantity} of snack number {snackIndex}, {snack.DisplaySnack()}\n");

        snackIndex++;

        if (snackIndex == snacks.Count)
        {
            snackbar.UpdateTotalRevenue(orderPrices);
            Console.WriteLine(snackbar.TotalRevenue);
            Console.WriteLine($"Your total revenue is {snackbar.TotalRevenue}\n");
            Console.WriteLine("\n \n \n");
            Console.WriteLine("Do you want to keep ordering? (Y or N)\n");
            string keepOrderingInput = Console.ReadLine()!;

            Console.WriteLine("Start again? Press [y]");
            var loop = Console.ReadLine();

            while (!(loop is "y" or "Y"))
            {
                Console.WriteLine("Invalid input. Press [y] to start again.");
                loop = Console.ReadLine();
            }

            takingOrder = loop is "y" or "Y";
            Console.Clear();

            snackIndex = 0;
        }
    }
    else
    {
        Console.WriteLine($"We don't have enough in stock. All we have is {snacks[snackIndex].AmountInStock}\n");
    }
    
}


int GetValidQuantityInput()
{
    while (true)
    {
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out int quantity) && quantity >= 0)
        {
            return quantity;
        }

        Console.WriteLine("Invalid input. Please enter a valid positive number.\n");
    }
}