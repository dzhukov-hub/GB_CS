using static System.Console;
Clear();
Write("Введите индекс строки массива: ");
int r_num = int.Parse(ReadLine());
WriteLine();
Write("Введите индекс столбца массива: ");
int c_num = int.Parse(ReadLine());
WriteLine();
int m = 3;
int n = 4;
int[,] MyArray = new int[m, n];
DeclareArray(MyArray);
PrintArray(MyArray);
WriteLine();
if (r_num < m && c_num < n)
    WriteLine($"Элемент массива: {GetArrayElement(MyArray, r_num, c_num)}");
else
    WriteLine("Такого элемента в массиве нет");
WriteLine();
void DeclareArray(int[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            MyArray[i, j] = new Random().Next(1, 99);
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

int GetArrayElement(int[,] MyArray, int r_num, int c_num)
{
    return MyArray[r_num, c_num];
}