// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] num1 = { { 2, 4 }, { 3, 2 } };
for (int i = 0; i < num1.GetLength(0); i++)
{
    for (int j = 0; j < num1.GetLength(1); j++)
    {
        Console.Write($"{num1[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();


int[,] num2 = { { 3, 4 }, { 3, 3 } };
for (int i = 0; i < num2.GetLength(0); i++)
{
    for (int j = 0; j < num2.GetLength(1); j++)
    {
        Console.Write($"{num2[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] numRes = new int[2, 2];

numRes[0,0] = (num1[0,0]*num2[0,0] + num1[0,1] * num2[1,0]); //ok
numRes[0,1] = (num1[0,0]*num2[0,1] + num1[0,1] * num2[1,1]); //ok
numRes[1,0] = (num1[1,0]*num2[0,0] + num1[1,1] * num2[1,0]); //ok
numRes[1,1] = (num1[1,0]*num2[0,1] + num1[1,1] * num2[1,1]); //ok

for (int i = 0; i < numRes.GetLength(0); i++)
{
    for (int j = 0; j < numRes.GetLength(1); j++)
    {
        Console.Write($"{numRes[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
