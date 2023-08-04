void FillArray(int[,] matrix, int MinValue = -9, int MaxValue = 9) 
{
    MaxValue++;
    Random random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(MinValue, MaxValue);
        }
    }
}

void PrintArray(int[,] matrix)
{
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Task54()
{
    // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

    int rows = 5;
    int columns = 6;
    int[,] numbers = new int[rows, columns];

    FillArray(numbers, -100, 100); 
    PrintArray(numbers);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int l = 0; l < columns - j - 1; l++)
            {
                if (numbers[i,l] < numbers[i,l+1])
                {
                    int temp = numbers[i,l];
                    numbers[i,l] = numbers[i,l+1];
                    numbers[i,l+1] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    PrintArray(numbers);
}

void Task56()
{
    // Задайте прямоугольный двумерный массив. Напишите программу, 
    // которая будет находить строку с наименьшей суммой элементов.

    int rows = 5;
    int columns = 6;
    int[,] numbers = new int[rows, columns];

    FillArray(numbers, 0, 2); 
    PrintArray(numbers);
    
    int[] sumInLines = new int[numbers.GetLength(0)];
    
    Console.Write("Суммы элементов в каждой строке: ");
    
    for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    sumInLines[i] += numbers[i, j];
                }
                Console.Write($"{sumInLines[i]} ");
        }
    int minI = 0;
    for (int i = 0; i < sumInLines.Length; i++)
        {
            if (sumInLines[minI] > sumInLines[i]) minI = i;
        }
    Console.Write($"Наименьшая сумма элементов: {sumInLines[minI]}");
   
}

Console.Clear();
Task54();