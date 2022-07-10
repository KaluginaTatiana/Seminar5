void Task34()
{
    // Задайте массив заполненный случайными положительными трёхзначными числами. 
    // Напишите программу, которая покажет количество чётных чисел в массиве.
    // [345, 897, 568, 234] -> 2
    // для наглядности сначала печатает таблицу
    int size = 10;
    int[] array1 = new int[size];
    FillArrayRandom(array1);
    Console.WriteLine("В таблице:");
    PrintArray(array1);
    int num = EvenNumbers(array1);
    Console.WriteLine($"{num} четных чисел.");


    void FillArrayRandom(int[] FillArray)
    {
        Random random = new Random();
        for (int i = 0; i < FillArray.Length; i++)
        {
            FillArray[i] = random.Next(100, 1000);
        }
    }

    int EvenNumbers(int[] array)
    {
        int evenNumbers = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] % 2 == 0)
                evenNumbers++;
        }
        return evenNumbers;
    }

    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}

Task34();

void Task36()
{
    // Задайте одномерный массив, заполненный случайными числами. 
    // Найдите сумму элементов, стоящих на нечётных позициях.
    //[3, 7, 23, 12] -> 19
    //[-4, -6, 89, 6] -> 0

    int size = 10;
    int[] array1 = new int[size];
    FillArrayRandom(array1);
    Console.WriteLine("В таблице:");
    PrintArray(array1);
    Console.WriteLine($"сумма элементов, стоящих на нечетных позициях равна {SumElem(array1)}.");



    void FillArrayRandom(int[] FillArray)
    {
        Random random = new Random();
        for (int i = 0; i < FillArray.Length; i++)
        {
            FillArray[i] = random.Next(-100, 100);
        }
    }

    int SumElem(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i = i + 2)
        {
            sum = sum + array[i];
        }
        return sum;
    }

    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}

Task36();

void Task38()
{
    // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    //[3 7 22 2 78] -> 76

    int size = 5;
    double[] array1 = new double[size];
    FillArrayRandom(array1);
    Console.WriteLine("В массиве:");
    PrintArray(array1);
    Console.WriteLine($"разница между максимальным и минимальным элементами равна {ElMax(array1) - ElMin(array1)}.");

    void FillArrayRandom(double[] FillArray)
    {
        Random random = new Random();
        for (int i = 0; i < FillArray.Length; i++)
        {
            FillArray[i] = Math.Round(random.NextDouble(), 2) + random.Next(-100, 100);
        }
    }

    void PrintArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

    double ElMax(double[] array)
    {
        double elMax = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > elMax)
                elMax = array[i];
        }
        return elMax;
    }

    double ElMin(double[] array)
    {
        double elMin = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < elMin)
                elMin = array[i];
        }
        return elMin;
    }
}

Task38();