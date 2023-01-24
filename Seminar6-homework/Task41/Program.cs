using static System.Console;
Clear();
WriteLine("Сколько чисел планируется для ввода?");
int m = int.Parse(ReadLine());
int[] MyArray = new int[m];
int CntPositiveNumbers = GetCntPositiveNumbers(MyArray);

WriteLine($"Введенные числа: [{String.Join(",", MyArray)}]");
WriteLine($"Количество положительных чисел: {CntPositiveNumbers}");

int GetCntPositiveNumbers(int[] MyArray)
{
    int CntPositiveNumbers = 0;
    for (int i = 0; i < MyArray.Length; i++)
    {
        MyArray[i] = int.Parse(ReadLine());
        CntPositiveNumbers += MyArray[i] > 0 ? 1 : 0;

    }
    return CntPositiveNumbers;
}

