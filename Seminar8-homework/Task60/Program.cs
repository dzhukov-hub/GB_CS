using static System.Console;
Clear();
int ar_size = 2;

int[,,] MyArray = DeclareArray(ar_size);
PrintArray(MyArray);


int[,,] DeclareArray(int ar_size)
{
    int[,,] MyArray = new int[ar_size, ar_size, ar_size];
    int inc = 0;
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            for (int k = 0; k < MyArray.GetLength(2); k++)
            {

                inc += 10;
                MyArray[i, j, k] = new Random().Next(inc, inc + 9);
            }

        }
    }
    return MyArray;
}

void PrintArray(int[,,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            for (int k = 0; k < MyArray.GetLength(2); k++)
            {
                Write($"{MyArray[i, j, k],3}({i},{j},{k})");
            }
            WriteLine();
        }
    }
}

