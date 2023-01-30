using static System.Console;
Clear();
int ar_size = 4;
int[,] MyArray = new int[ar_size, ar_size];

DeclareArray(MyArray);

PrintArray(MyArray);
WriteLine();
WriteLine($"Номер строки с наименьшей сумой: {FindRowMinSum(MyArray)}");
WriteLine();
int FindRowMinSum(int[,] MyArray)
{
    int RowNumMinSum = 1;
    int MinSum = 0;
    int RowSum = 0;

    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        RowSum = 0;
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            RowSum += MyArray[i, j];
        }
        RowNumMinSum = (RowSum < MinSum || MinSum == 0) ? i + 1 : RowNumMinSum;
        MinSum = (RowSum < MinSum || MinSum == 0) ? RowSum : MinSum;
    }
    return RowNumMinSum;
}

void DeclareArray(int[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            MyArray[i, j] = new Random().Next(1, 9);
        }
    }
}

void PrintArray(int[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            Write($"{MyArray[i, j],8}");
        }
        WriteLine();
    }
}