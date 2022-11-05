// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1
// 2
// -> 4

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

void SerchNumber(int[,] matrix)
{
    Console.WriteLine("Введите номер строки: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца: ");
    int m = Convert.ToInt32(Console.ReadLine());
  
        if (matrix.GetLength(0) >= n && matrix.GetLength(1) >= m)
            Console.WriteLine($"Искомое число: {matrix[n - 1, m - 1]}");
        else
            Console.WriteLine("Введенные данные не верны");
        
                        
}


Console.Clear();
int[,] matrix = new int[3, 4];
// Console.WriteLine();
// Console.WriteLine("Введите номер столбца: ");
// Console.WriteLine();
// Console.WriteLine("Введите номер строки: ");
InputMatrix(matrix);
SerchNumber(matrix);

