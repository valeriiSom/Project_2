Console.Write("Enter number");
string number1 = Console.ReadLine();
int num1 = int.Parse(number1);

Console.Write("Enter number");
string number2 = Console.ReadLine();
int num2 = int.Parse(number2);

if (num1 * num1 == num2 || num2 * num2 == num1)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}