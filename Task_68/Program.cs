int FuncAckerman(int numberM, int numberN)
{
    if (numberM == 0)
        return numberN + 1;
    else if (numberM != 0 && numberN == 0)
        return FuncAckerman(numberM - 1, 1);
    else if (numberM > 0 && numberN > 0)
        return FuncAckerman(numberM - 1, FuncAckerman(numberM, numberN - 1));
    else
        return FuncAckerman(numberM, numberN);
}


Console.Clear();


Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());


int ackermanResult = FuncAckerman(numberM, numberN);


Console.WriteLine($"\nФункция Аккермана для A({numberM}, {numberN}): " + ackermanResult);