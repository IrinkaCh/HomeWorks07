Console.Write("Введите количество строк, m: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов, n: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

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

int FindNumberInArray(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (number == array[i, j])
            {
                count = count + 1;
                Console.WriteLine($"{array[i, j]} -> {i}, {j}");
            }
        }
    }
    if (count == 0) { Console.WriteLine($"{number} -> нет такого элемента"); }

    return number;
}


int numbers = FindNumberInArray(result);
