// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите количество строк 1-ой матрицы: "); int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1-ой и количество строк 2-ой: "); int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2-ой матрицы: "); int p = Convert.ToInt32(Console.ReadLine());
int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix); Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);
int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix); Console.WriteLine($"Вторая матрица:");
WriteArray(secomdMartrix);
int[,] arrMatrix = new int[m,p];
MultiplyMatrix(firstMartrix, secomdMartrix, arrMatrix); Console.WriteLine($"Произведение матриц:");
WriteArray(arrMatrix);
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++) sum += firstMartrix[i,k] * secomdMartrix[k,j];
      resultMatrix[i,j] = sum;
    }
  }
}
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(10);
  }
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i,j] + " ");
    Console.WriteLine();
  }
}