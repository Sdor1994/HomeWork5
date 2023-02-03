// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] a = new double[3, 3];
Random random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}