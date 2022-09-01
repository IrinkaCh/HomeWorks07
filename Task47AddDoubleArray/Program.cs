System.Console.Write("Введите количество строк, m: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
System.Console.Write("Введите количество столбцов, n: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberM == false || isNumberN == false)
{
    Console.WriteLine("Введены не правильные данные.");
    return;
}

double[,] result = FillArray2D(m, n, -10, 11);
RoundedArray2D(result);

double[,] FillArray2D(int m, int n, int minValue, int maxValue)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1) + random.NextDouble();
        }
    }
    return array;
}

void RoundedArray2D(double[,] array)
{
    double rounding = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rounding = Math.Round(array[i, j], 1);
            Console.Write($"{rounding}  ");
        }

        Console.WriteLine();
    }
}
