Console.Clear();
Console.WriteLine("Напишите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine(number1 + " большее число, а " + number2 + " меньшее число");
}
else
{
    Console.WriteLine(number2 + " большее число, а " + number1 + " меньшее число");
}