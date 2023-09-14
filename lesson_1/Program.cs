int num = new Random().Next(10,100);

int num1 = num / 10;
int num2 = num % 10;

if(num1 > num2 )
{
    Console.WriteLine($" max = {num1}");
}
else
{
    Console.WriteLine(" max = " + num2);
}