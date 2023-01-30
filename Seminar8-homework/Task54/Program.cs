using static System.Console;
Clear();
int r_num = 3;
int c_num = 4;
int[,] MyArray = new int[r_num, c_num];
DeclareArray(MyArray);
PrintArray(MyArray);
WriteLine();
SortArray(MyArray);
PrintArray(MyArray);
WriteLine();
void DeclareArray(int[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            MyArray[i, j] =  new Random().Next(1, 9);
        }
    }
}

void SortArray(int[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            for (int n = 0; n < MyArray.GetLength(1); n++)
            {
                for (int k = 0; k < MyArray.GetLength(1) - 1; k++)
                {
                    int TempArrayValue = MyArray[i, k + 1];
                    if (MyArray[i, k] < MyArray[i, k + 1])
                    {
                        MyArray[i, k + 1] = MyArray[i, k];
                        MyArray[i, k] = TempArrayValue;
                    }
                }
            }
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
