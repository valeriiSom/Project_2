Console.Write("Enter number");
string number1 = Console.ReadLine();
int num1 = int.Parse(number1);

Console.Write("Enter number");
string number2 = Console.ReadLine();
int num2 = int.Parse(number2);

int num3 = num1 % num2;

if (num3 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно {num3}");
}