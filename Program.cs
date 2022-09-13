//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("Введите количество строк двумерного массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
void OrderArr(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(1) - 1; k++)
      {
        if (arr[i, k] < arr[i, k + 1])
        {
          int temp = arr[i, k + 1];
          arr[i, k + 1] = arr[i, k];
          arr[i, k] = temp;
        }
      }
    }
  }
}
void Randarr(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++) arr[i, j] = new Random().Next(100);
  }
}
void Writearr(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++) Console.Write(arr[i, j] + " "); Console.WriteLine();
  }
}
Console.WriteLine($"\nЗаданный массив:");
Randarr(arr);
Writearr(arr);
Console.WriteLine($"\nВ итоге получается вот такой массив:");
OrderArr(arr);
Writearr(arr);