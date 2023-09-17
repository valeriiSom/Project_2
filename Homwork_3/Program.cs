Console.Write("Enter number");
string number = Console.ReadLine();
int num = int.Parse(number);

if (num < 100 || num > 999)
{
    Console.Write($"Введенное число некоректно {num}");
}
else
{
    int num2 = (num % 100) / 10;
    Console.WriteLine($"Вторая цифра {num2}");
}