using static System.Console;
Clear();
GetArr();


void GetArr()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 99);
    }

    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}");
        if (i != array.Length - 1)
            Write(',');

    }
}