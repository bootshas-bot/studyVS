// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter 2 number:");
var input1 = Console.ReadLine();
var input2 = Console.ReadLine();
int num1 = int.Parse(input1);
int num2 = int.Parse(input2);
Console.Write($"{Environment.NewLine}Two number total is {num1+num2}");
Console.Write($"{Environment.NewLine}Press Enter to exit...");
Console.Read();