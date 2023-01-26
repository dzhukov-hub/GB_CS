using static System.Console;
Clear();
int m = 3;
int n = 4;
double[,] MyArray = new double[m, n];
DeclareArray(MyArray);
PrintArray(MyArray);

void DeclareArray(double[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            int PosNeg = new Random().Next(-1, 1);
            PosNeg = (PosNeg == 0) ? 1 : PosNeg;
            MyArray[i, j] = new Random().NextDouble() * 10;
            MyArray[i, j] = Math.Round(MyArray[i, j], 1) * PosNeg;
        }
}

void PrintArray(double[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
            Write($"{MyArray[i, j],8}");
        WriteLine();
    }
}



