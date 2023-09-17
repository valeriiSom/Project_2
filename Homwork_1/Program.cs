int num(int number)
{
int result = -1;
if (number >= 100)
{
while (number > 999)
{
number = number / 10;
}
result = number % 10;
}
return result; 
}

Console.Write("Введите трехзначное число: ");
int number1 = int.Parse(Console.ReadLine());
 
if (num(number1) == -1)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"Третья цифра - это {num(number1)}");