Console.Write("Enter number");
string number = Console.ReadLine();
int num = int.Parse(number);
if (num > 0 && num < 8)
if (num == 7 || num == 6)
{
Console.Write("Под цифрой " + num + " - Выходной");
}
else
{
Console.Write("Под цифрой " + num + " - Рабочий");
}
else
{
Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
}