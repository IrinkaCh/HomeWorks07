Console.Write("Введите количество строк, m: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов, n: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberM == false || isNumberN == false)
{
    Console.WriteLine("Введены не правильные данные.");
    return;
}

int[,] result = FillArray2D(m, n, 0, 11);
PrArray2D(result);
Console.WriteLine();

int[,] FillArray2D(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindArithmeticalMean(int[,] array)
{
    double sum = 0;
    double arithmeticalMean = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        arithmeticalMean = sum / array.GetLength(0);
        double rounding = Math.Round(arithmeticalMean, 2);
        Console.WriteLine($"Среднее арифметическое столбца " + (j + 1) + " равно: " + rounding);
        sum = 0;
    }
}

FindArithmeticalMean(result);