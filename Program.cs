// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] num = new int[4, 4];
num[0, 0] = 1;
int sum = 0;

for (int i = 0; i < 1; i++) // 1-4
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        sum = sum + 1;
        num[i, j] = sum;
    }
}

for (int i = 1; i < num.GetLength(0); i++) // 5-7
{
    for (int j = 3; j <= 3; j++)
    {
        sum = sum + 1;
        num[i, j] = sum;
    }
}

for (int i = 3; i <= 3; i++) // 8-10
{
    for (int j = 2; j >= 0; j--)
    {
        sum = sum + 1;
        num[i, j] = sum;
    }
}

for (int i = 2; i > 0; i--) // 11-12
{
    for (int j = 0; j >= 0; j--)
    {
        sum = sum + 1;
        num[i, j] = sum;
    }
}

for (int i = 1; i <= 1; i++) // 13-14
{
    for (int j = 1; j < 3; j++)
    {
        sum = sum + 1;
        num[i, j] = sum;
    }
}

num[2, 2] = num[1, 2] + 1; // 15-16
num[2, 1] = num[2, 2] + 1;

for (int i = 0; i < num.GetLength(0); i++) // демонстрация массива
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
