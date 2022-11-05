// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}

void ArithmeticMeanNumber (int[,] matrix)
{
    double result = Convert.ToDouble(0.1);
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            summ += matrix[j,i];
        }
        result = summ/matrix.GetLength(0);
        Console.WriteLine($"Среднеарифметическое: {Math.Round(result, 1)}");
    }
}
Console.Clear();
int[,] matrix = new int[3, 4];
InputMatrix(matrix);
ArithmeticMeanNumber(matrix);