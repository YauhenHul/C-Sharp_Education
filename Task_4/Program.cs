Console.Clear();
Console.WriteLine("Напишите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите третье число");
int number3 = int.Parse(Console.ReadLine());
int max = 0;
if (number2 > number1)
{
    max = number2;
}
else
{
    max = number1;
}

if (number3 > max)
{
    max = number3;
}
Console.WriteLine(max + " наибольшее число");