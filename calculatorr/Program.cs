// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Welcome to the calculator program!");
Console.WriteLine("Please enter your first number.");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your second number.");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What type of operation would you like to do?");
Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication or d for division.");

string answer = Console.ReadLine();
int result;

if(answer == "a")
{
    result = num1 + num2;
}
else if (answer == "s")
{
    result = num1 - num2;
}
else if(answer == "m")
{
    result = num1 * num2;
}
else 
{
    result = num1 / num2;
};

Console.WriteLine("The result is " + result);
