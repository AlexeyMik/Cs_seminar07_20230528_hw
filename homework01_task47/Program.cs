// Задача 47: Задайте двумерный массив mXn, заполненный случайными внщественными числами
// 20230528 2330

void Task47()
{
    int m = ReadInt("Введите количество строк: ");
    int n = ReadInt("Введите количество столбцов: ");
    double leftLimit = ReadDouble("Введите нижнюю границу генерируемых значений: ");
    double rightLimit = ReadDouble("Введите верхнюю границу генерируемых значений: ");
    double[,] matrix = GenerateDoubleValueMatrix(m, n, leftLimit, rightLimit);
    PrintDoubleValueMatrix(matrix, 2);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
double ReadDouble(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double[,] GenerateDoubleValueMatrix(int row, int col, double dLeftRange, double dRightRange)
{
    double[,] matrix = new double[row, col];
    Random rand = new Random();
    double amplitude = dRightRange - dLeftRange;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = dLeftRange + rand.NextDouble() * amplitude;
        }
    }
    return matrix;
}

void PrintDoubleValueMatrix(double[,] matrix, int roundFigure)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(Math.Round(matrix[i, j], roundFigure) + "\t");
        }
        System.Console.WriteLine();
    }
}

Task47();

