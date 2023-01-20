// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

int[,] num = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// int Sum(int X) // не удачная попытка создать метод ((
// {
// int sumX = 0;
// int jX = 0;
// for (int iX = 0; jX < num.GetLength(0); jX++)
// {    sumX = sumX + num[iX, jX];
// } return test;
// //Console.WriteLine(sum0); //проверка
// }
// Console.WriteLine(test);

// int X = 1;
// Sum(X);
// Console.WriteLine(test);

int sum0 = 0; // тут вводил каждый раз новые названия переменнх, т.к. постояно происходили конфликты.
int j0 = 0;
for (int i0 = 0; j0 < num.GetLength(0); j0++)
{    sum0 = sum0 + num[i0, j0];
} //Console.WriteLine(sum0);

int sum1 = 0;
int j1 = 0;
for (int i1 = 1; j1 < num.GetLength(0); j1++)
{    sum1 = sum1 + num[i1, j1];
} //Console.WriteLine(sum1);

int sum2 = 0;
int j2 = 0;
for (int i2 = 2; j2 < num.GetLength(0); j2++)
{    sum2 = sum2 + num[i2, j2];
} //Console.WriteLine(sum2);

int sum3 = 0;
int j3 = 0;
for (int i3 = 3; j3 < num.GetLength(0); j3++)
{    sum3 = sum3 + num[i3, j3];
} //Console.WriteLine(sum3);

int sumMin = sum0;
if (sum1<sumMin) {sumMin = sum1;};
if (sum2<sumMin) {sumMin = sum2;};
if (sum3<sumMin) {sumMin = sum3;};
//Console.WriteLine(sumMin);

if (sumMin == sum0) {Console.WriteLine("1 строка");};
if (sumMin == sum1) {Console.WriteLine("2 строка");};
if (sumMin == sum2) {Console.WriteLine("3 строка");};
if (sumMin == sum3) {Console.WriteLine("4 строка");};

