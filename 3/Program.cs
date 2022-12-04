double[] GenerateArray(int Length, int minRange, int maxRange)
{

    double[] array = new double[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
}

double MaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > max) { max = array[j]; }
        if (array[j] < min) { min = array[j]; }
    }
    return max - min;
}


double[] array = GenerateArray(4, -100, 100);
System.Console.WriteLine("Сгенерирован массив: ");
PrintArray(array);
System.Console.WriteLine("");
System.Console.WriteLine("разницa между максимальным и минимальным элементов массива: ");
System.Console.WriteLine(MaxMin(array));