Console.Clear();
Console.WriteLine("Введите трёхзначное число:");
int digit = Convert.ToInt16(Console.ReadLine());

int secondDigit = (digit / 10) % 10;
Console.WriteLine("Вторая цифра числа: " + secondDigit);