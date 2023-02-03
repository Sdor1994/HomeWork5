// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int length= ReadInt("Введите колличество строк: ");
int width= ReadInt("Введите колличество столбцов: ");
int left= ReadInt("Введите левый предел чисел: ");
int right= ReadInt("Введите правый предел чисел: ");

double[,] matrix = new double[length, width];
Console.WriteLine();
Console.WriteLine("Изначальная матрица: ");
Random random = new Random();
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width; j++)
    {
        matrix[i, j] = random.Next(left,right);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Измененная матрица: ");

for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width; j++)
    {
        if ( i%2 ==0 && j%2 ==0 ) 
        {
            matrix[i,j]= matrix[i,j]* matrix[i,j];
            Console.Write(matrix[i, j] + "\t");
        }
    Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();