//Script that ask for two integer numbers as inputs
//output: (I)sum, (II) difference, (III) product, and (IV) remainder

//Collect the input

Console.WriteLine("Type two numbers to calculate their; (I) sum, (II) difference, (III) product, and (IV) the remainder");
Console.Write("Type the first number ");
string? firstNumberAsString = Console.ReadLine();
Console.Write("Type the second number ");
string? secondNumberAsString = Console.ReadLine();

//Check for valid integers
if(!int.TryParse(firstNumberAsString, out int firstNumber) || !int.TryParse(secondNumberAsString, out int secondNumber))
{
    Console.WriteLine("You keyed in a wrong number. Try again - bye");
}
else
{
    //Calculations
    int sum = firstNumber + secondNumber;
    int difference = firstNumber - secondNumber;
    int product = firstNumber * secondNumber;
    int remainder = firstNumber % secondNumber;

    //Output
    Console.WriteLine($"The first number is {firstNumber}{Environment.NewLine}The second number is {secondNumber}{Environment.NewLine}The sum is {sum}{Environment.NewLine}The difference is {difference}{Environment.NewLine}The product is {product}{Environment.NewLine}And the remainder is {remainder}{Environment.NewLine}");
}


