//Ask for a price (with decimal) and amount and calculate the total price

Console.Write("What is the price? ");
string? priceToString = Console.ReadLine();

Console.Write("What is the amount? ");
string? amountToString = Console.ReadLine();

if(!double.TryParse(priceToString, out double price) || !int.TryParse(amountToString, out int amount))
Console.WriteLine("Something went wrong, typ a price (with/without decimal) and amount using numbers only - try again.");

else
Console.WriteLine($"The total sum is {amount * price}");