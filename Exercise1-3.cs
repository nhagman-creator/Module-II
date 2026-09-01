//Module-II---Day-1---31Aug2026

//Ask for name
Console.Write("Type your name: ");
string? nameInput = Console.ReadLine();


//check if nameInput contains only letters and is not empty
/*bool isAllLetters(string nameInput)
{
    if(string.IsNullOrEmpty(nameInput)) return false;

    foreach(char c in nameInput)
    {
        if(!char.IsLetter(c))
        return false;
    }
}*/


//Ask for age - string input
Console.Write("Type your age: ");
string? ageInputAsString = Console.ReadLine();

//Test if ageInputAsString is not null and can be parsed to an integer, otherwise set ageInput to 0
if (!int.TryParse(ageInputAsString, out int ageInput))
{
    Console.WriteLine($"Only numbers are accepted as input, bye");
}


//Test print variables
//Console.WriteLine($"{isAllLetters}!");
//Console.WriteLine($"Hello you wrote your name as '{nameInput}', and year as '{ageInput}!");
Console.WriteLine($"Hello {nameInput}, next year you will be {ageInput + 1}!");


/*
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
*/