// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
//
void Task50()
{
    int m = ReadInt("Введите количество строк: ");
    int n = ReadInt("Введите количество столбцов: ");

    int[,] matrixI = GenerateIntValueMatrix(m, n, 0, 99);
    PrintIntValueMatrix(matrixI);

    int ind1 = ReadInt("Введите первый индекс элемента: ");
    int ind2 = ReadInt("Введите второй индекс элемента: ");
    if (CheckAccessability(matrixI, ind1, ind2))
    {
        //Console.WriteLine($" индексы строки {ind1} и столбца {ind2} допустимы.");
        Console.WriteLine($" элемент[{ind1},{ind2}] = {matrixI[ind1, ind2]}");
    }
    else
    {
        System.Console.WriteLine($" индексы строки {ind1} и/или столбца {ind2} не допустимы.");
    }
}

bool CheckAccessability(int[,] matrix, int index0, int index1)
{
    return (0 <= index0 && index0 < matrix.GetLength(0) && 0 <= index1 && index1 < matrix.GetLength(1));
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

Task50();
