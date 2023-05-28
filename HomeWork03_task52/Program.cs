// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//  20230529 0004
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void Task52()
{
    int m = ReadInt("Введите количество строк: ");
    int n = ReadInt("Введите количество столбцов: ");
    int leftLimit = ReadInt("Введите нижнюю границу генерируемых значений: ");
    int rightLimit = ReadInt("Введите верхнюю границу генерируемых значений: ");
    int[,] matrixI = GenerateIntValueMatrix(m, n, leftLimit, rightLimit);
    PrintIntValueMatrix(matrixI);

    double[] averagesInColumns = AverageForColumns(matrixI);
    System.Console.WriteLine();
    System.Console.WriteLine("средние арифметические столбцов: ");
    PrintDoubleArray(averagesInColumns, 2);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateIntValueMatrix(int nRow, int nColumn, int leftRange, int rightRange)
{
    int[,] matrix = new int[nRow, nColumn];// по построению nRow==matrix.GetLength(0), nColumn==matrix.GetLength(1)
    Random rand = new Random();
    for (int i = 0; i < nRow; i++)
    {
        for (int j = 0; j < nColumn; j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
            //matrix[i, j] = i * 100 + j; //использовалось для отладки
        }
    }
    return matrix;
}

void PrintIntValueMatrix(int[,] matrix) // печать 2-мерного массива с целыми значениями  
{
    for (int i = 0; i < matrix.GetLength(0); i++) // внешний цикл - по строкам: идем от нулевой до последней
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] AverageForColumns(int[,] matrix) // возвращает 1-мерный вещественно-значный массив со средними ариметическими каждого столбца
{
    double[] averages = new double[matrix.GetLength(1)];
    double buffer = 0;
    int nLines = matrix.GetLength(0);
    for (int j = 0; j < matrix.GetLength(1); j++) // внешний цикл - по столбцам
    {
        buffer = 0;
        for (int i = 0; i < nLines; i++)
        {
            buffer += Convert.ToDouble(matrix[i, j]);
        }
        averages[j] = buffer / nLines;
    }
    return averages;
}
void PrintDoubleArray(double[] dArray, int roundFigure) // печатает в одну строку 
//элементы doubleValue одномерного массива с заданным количеством roundFigure десятичных знаков
{
    for (int i = 0; i < dArray.Length; i++)
    {
        System.Console.Write(Math.Round(dArray[i], roundFigure) + "\t");
    }
    System.Console.WriteLine();
}
Task52();

