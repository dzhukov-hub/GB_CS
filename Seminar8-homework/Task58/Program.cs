using static System.Console;
Clear();
int ar_size = 2;
int[,] MyArray1 = DeclareArray(ar_size);
int[,] MyArray2 = DeclareArray(ar_size);


int[,] MultTwoArrays = GetMultTwoArrays(MyArray1, MyArray2);

PrintArray(MyArray1);
WriteLine();
PrintArray(MyArray2);
WriteLine();
PrintArray(MultTwoArrays);
WriteLine();



int[,] GetMultTwoArrays(int[,] MyArray1, int[,] MyArray2)
{
    int[,] MultTwoArrays = new int[MyArray1.GetLength(0), MyArray2.GetLength(1)];
    for (int i1 = 0; i1 < MyArray1.GetLength(0); i1++)
    {
        for (int j2 = 0; j2 < MyArray2.GetLength(1); j2++)
        {
            for (int j1 = 0; j1 < MyArray2.GetLength(1); j1++)
            {
                MultTwoArrays[i1, j2] += MyArray1[i1, j1] * MyArray2[j1, j2];
            }
        }
    }
    return MultTwoArrays;
}





int[,] DeclareArray(int ar_size)
{
    int[,] MyArray = new int[ar_size, ar_size];
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            MyArray[i, j] = new Random().Next(1, 9);
        }
    }
    return MyArray;
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