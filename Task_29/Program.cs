void FillArrayRandom(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(100); // случайное число [0, 99]
    }
}


void PrintArray(int[] collection)
{
    Console.Write("[");
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i]);
        if (i < collection.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}


Console.Clear();


int elements = 8; // кол-во элементов в массиве
int[] array = new int[elements];


FillArrayRandom(array);
PrintArray(array);