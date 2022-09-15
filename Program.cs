﻿// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine("Введите размер массива x: "); int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива y: "); int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива z: "); int z = Convert.ToInt32(Console.ReadLine());
int[,,] arr = new int[x, y, z];
CreateArray(arr);
WriteArray(arr);
void WriteArray (int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++) Console.Write( $"{arr[i,j,k]}({j}, {k}, {i}) ");
      Console.WriteLine();
    }
  }
}
void CreateArray(int[,,] arr)
{
  int[] temp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100); number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100); j = 0; number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arr.GetLength(0); x++)
  {
    for (int y = 0; y < arr.GetLength(1); y++)
    {
      for (int z = 0; z < arr.GetLength(2); z++) arr[x, y, z] = temp[count]; count++;
    }
  }
}
