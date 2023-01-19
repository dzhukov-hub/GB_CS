using static System.Console;
Clear();
int[] Arr = new int[4];

DeclareArr();
int ArrCntEven = GetArrCntEven(Arr);
PrintArr(Arr);
WriteLine();
WriteLine($"Количество четных чисел массива: {ArrCntEven}");


void DeclareArr()
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(1, 999);
    }
}

int GetArrCntEven(int[] Arr)
{
    int cnt = 0;
    foreach (var a in Arr)
    {
        cnt += (a % 2 == 0) ? 1 : 0;
    }
    return cnt;

}

void PrintArr(int[] Arr)
{
    string res = "";
    Write("[");
    foreach (var i in Arr)
    {
        res += $"{i},";
    }
    Write($"{res}".Trim(','));
    Write("]");
}



