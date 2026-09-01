//Module-II---Day-1---31Aug2026
//Declare variables

string name = "Ada";
int age = 36;
double height = 1.72;
bool isDeveloper = true;

//Write to, and read from console with string interpolation
Console.Write("Vad heter du? ");
string? answer = Console.ReadLine();
Console.WriteLine($"Hej {answer}!");


Console.WriteLine($"{name} är {age} år och {height} m lång.");

//Mathematical operations on console using int and double
int a = 7;
int b = 3;
double c = 7.5;
double d = 3.2;

Console.WriteLine($"Summa: {a + b}");    // 10
Console.WriteLine($"Produkt: {a * b}");  // 21
Console.WriteLine($"Rest: {a % b}");     // 1  (modulo — resten vid division)

//Example of reading an integer from the console and performing a calculation
Console.Write("Ange ett heltal: ");
string? input = Console.ReadLine();

//Safely parse the input to an integer and perform a calculation
if (int.TryParse(input, out int number))
{
    Console.WriteLine($"Du skrev {number}. Dubbelt så mycket är {number * 2}.");
}
else
{
    Console.WriteLine("Det där var inget giltigt heltal.");
}

//Safely parse the input to a double and display it
if (double.TryParse(input, out double price))
{
    Console.WriteLine($"Priset är {price} kr.");
}