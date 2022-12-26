Console.Clear();
int[] EntryPointCoordinates(int[] arr, int indexPoint)
{
    string[] lines = { "X", "Y", "Z" };

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите координаты {lines[i]}{indexPoint}:");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

double CalcDistanceIn3D(int[] tmpPointOne, int[] tmpPointTwo) // [0] - X, [1] - Y, [2] - Z
{
    double sumSquares = 0;
    for (int i = 0; i < tmpPointOne.Length; i++)
    {
        sumSquares += Math.Pow(tmpPointTwo[i] - tmpPointOne[i], 2);
    }
    double result = Math.Sqrt(sumSquares);
    return result;
}

int[] pointOne = new int[3];
int[] pointTwo = new int[3];

pointOne = EntryPointCoordinates(pointOne, 1);
Console.WriteLine();
pointTwo = EntryPointCoordinates(pointTwo, 2);

double result = CalcDistanceIn3D(pointOne, pointTwo);
Console.WriteLine("Расстояние между точками в 3D пространстве: " + result);