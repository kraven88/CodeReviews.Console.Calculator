
// Declare variables and initialize with zero;
int num1 = 0;
int num2 = 0;

// Display title as the C# console calculator app;
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number;
Console.WriteLine("Type a number, and then press Enter");
num1 = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number;
Console.WriteLine("Type another number, then press Enter");
num2 = Convert.ToInt32(Console.ReadLine());

// Ask the user to choose an option;
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your choice: ");

// Use a switch statement to do the operation;
switch (Console.ReadLine().ToLower())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "b":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "c":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}

// Wait for the user to respond before closing the app;
Console.Write("Press any key to close the application.");
Console.ReadKey();
