using static System.Console;
using static System.Math;
Clear();
int m = 3;
int n = 4;
int[,] MyArray = new int[m, n];
DeclareArray(MyArray);
PrintArray(MyArray);
WriteLine();
PrintAvgColumnValues(MyArray);
WriteLine();
WriteLine();

void PrintAvgColumnValues(int[,] MyArray)
{
    Write("Среднее арифметическое каждого столбца: ");
    double c_avg;
    int c_num;
    for (int i = 0; i < MyArray.GetLength(1); i++)
    {
        c_avg = 0;
        c_num = 0;
        for (int j = 0; j < MyArray.GetLength(0); j++)
        {
            c_avg += MyArray[j, i];
            c_num++;
        }
        Write($"{Round(c_avg / c_num, 1)}; ");
    }
}


void DeclareArray(int[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            MyArray[i, j] = new Random().Next(1, 10);
        }
}

void PrintArray(int[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
            Write($"{MyArray[i, j],8}");
        WriteLine();
    }
}

