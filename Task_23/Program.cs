Console.Clear();

void TableCubes(string str)
{
    Console.Write(str);
    double number = double.Parse(Console.ReadLine());
    int count = 1;
    double cube;

    Console.WriteLine($"Таблица кубов чисел от {count} до {number}:");
    while (count <= number)
    {
        cube = Math.Pow(count, 3);
        Console.Write(cube + " ");
        count++;
    }
    Console.WriteLine();
}

TableCubes("Введите число N: ");