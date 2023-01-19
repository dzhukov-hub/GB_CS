using static System.Console;
Clear();
int[] Arr = new int[4];

DeclareArr();
int ArrCntEven = GetSumValArrOdd(Arr);
PrintArr(Arr);
WriteLine();
WriteLine($"Сумма элементов, стоящих на нечётных позициях: {ArrCntEven}");


void DeclareArr()
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(-99, 99);
    }
}

int GetSumValArrOdd(int[] Arr)
{
    int sum = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        sum += (i % 2 != 0) ? Arr[i] : 0;
    }
    return sum;

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




