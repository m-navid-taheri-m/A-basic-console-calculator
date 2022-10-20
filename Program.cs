﻿

// Declare variables and then initialize to zero.
int num1 = 0; int num2 = 0;
bool flag = true;
string answer = "";
// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");


while (flag)
{
    // Ask the user to type the first number.
    Console.WriteLine("Type a number, and then press Enter");
    num1 = Convert.ToInt32(Console.ReadLine());

    // Ask the user to type the second number.
    Console.WriteLine("Type another number, and then press Enter");
    num2 = Convert.ToInt32(Console.ReadLine());

    // Ask the user to choose an option.
    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("\ta - Add");
    Console.WriteLine("\ts - Subtract");
    Console.WriteLine("\tm - Multiply");
    Console.WriteLine("\td - Divide");
    Console.WriteLine("\te - Exit");
    Console.Write("Your option? ");
    // Use a switch statement to do the math.
    switch (Console.ReadLine())
    {
        case "a":
            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
            break;
        case "s":
            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
            break;
        case "m":
            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
            break;
        case "d":
            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            break;
        case "e":
            Environment.Exit(1);
            break;
    }

    Console.WriteLine("Do you still want to continue ?   yes/no");
    answer = Console.ReadLine();
    if (answer=="yes") 
        flag = true;   
    else if(answer == "no"){
        flag = false;
        Environment.Exit(1);
    };
}
