Console.Clear();


void NaturalNumbers(int startNumber)
{
    if (startNumber == 1) Console.Write(startNumber);
    else
    {
        Console.Write(startNumber + ", ");
        NaturalNumbers(startNumber - 1);
    }
}


Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());


NaturalNumbers(numberN);
Console.WriteLine();