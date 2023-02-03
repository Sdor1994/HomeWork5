// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int length= ReadInt("Введите колличество строк: ");
int width= ReadInt("Введите колличество столбцов: ");


double[,] matrix = new double[length, width];
Console.WriteLine();
Console.WriteLine("Изначальная матрица: ");
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width; j++)
    {
        matrix[i, j] = i+j;
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

