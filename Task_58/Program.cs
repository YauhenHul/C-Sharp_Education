int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }

            matrixC[i, j] = sum;
        }
    }

    return matrixC;
}


int EnterDataNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


void FillRandomIntArray(int[,] array, int leftRange, int rightRange)
{
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rand.Next(leftRange, rightRange + 1);
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}


Console.Clear();


const int leftRangeRandom = 0;
const int rightRangeRandom = 9;


int sizeRowsMatrixA = EnterDataNumber("Введите количество строк в матрице A: ");
int sizeColsMatrixA = EnterDataNumber("Введите количество столбцов в матрице A: ");
int sizeRowsMatrixB = sizeColsMatrixA; // иначе матрицы невозможно перемножить!
System.Console.WriteLine("\nКоличество строк в матрице B: " + sizeRowsMatrixB);
int sizeColsMatrixB = EnterDataNumber("Введите количество столбцов в матрице B: ");


int[,] myMatrixA = new int[sizeRowsMatrixA, sizeColsMatrixA];
int[,] myMatrixB = new int[sizeRowsMatrixB, sizeColsMatrixB];
int[,] myMatrixC = new int[sizeRowsMatrixA, sizeColsMatrixB];


FillRandomIntArray(myMatrixA, leftRangeRandom, rightRangeRandom);
FillRandomIntArray(myMatrixB, leftRangeRandom, rightRangeRandom);


System.Console.WriteLine("Матрица A: ");
PrintArray(myMatrixA);


System.Console.WriteLine("\nМатрица B: ");
PrintArray(myMatrixB);
Console.WriteLine();


myMatrixC = MultiplicationMatrix(myMatrixA, myMatrixB);
Console.WriteLine("Результат перемножения матриц A x B: ");
PrintArray(myMatrixC);