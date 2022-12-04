int[] GenerateArray(int Length, int minRange, int maxRange)
{

    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
}

int NumChet(int[] array)
{
    int r = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
        {
            r++;
        }
    }
    return r;
}

//

int[] array = GenerateArray(4, 100, 1000);
System.Console.WriteLine("Сгенерирован массив: ");
PrintArray(array);
System.Console.WriteLine("Количество четных элементов: " + NumChet(array));


