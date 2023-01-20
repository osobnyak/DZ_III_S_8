// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] num = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int[,] num2 = new int[3, 4];

for (int i = 0; i < num.GetLength(0); i++) // демонстрация изначального массива.
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();

}
Console.WriteLine();

int max00 = 0;
int max01 = 0;
int max02 = 0;
int max03 = 0;

if (num[0, 0] > max00) { max00 = num[0, 0]; }
if (num[0, 1] > max00) { max00 = num[0, 1]; }
if (num[0, 2] > max00) { max00 = num[0, 2]; }
if (num[0, 3] > max00) { max00 = num[0, 3]; }
num2[0, 0] = max00; 

if (num[0, 0] > max01 && num[0, 0] < max00){ max01 = num[0, 0]; } //Console.WriteLine($"[0,1] = {max01}; "); // проверка.
if (num[0, 1] > max01 && num[0, 1] < max00){ max01 = num[0, 1]; } //Console.WriteLine($"[0,1] = {max01}; ");
if (num[0, 2] > max01 && num[0, 2] < max00){ max01 = num[0, 2]; } //Console.WriteLine($"[0,1] = {max01}; ");
if (num[0, 3] > max01 && num[0, 3] < max00){ max01 = num[0, 3]; } //Console.WriteLine($"[0,1] = {max01}; ");
num2[0, 1] = max01;

if (num[0, 0] > max02 && num[0, 0] < max01){ max02 = num[0, 0]; }
if (num[0, 1] > max02 && num[0, 1] < max01){ max02 = num[0, 1]; }
if (num[0, 2] > max02 && num[0, 2] < max01){ max02 = num[0, 2]; }
if (num[0, 3] > max02 && num[0, 3] < max01){ max02 = num[0, 3]; }
num2[0, 2] = max02;

if (num[0, 0] > max03 && num[0, 0] < max02){ max03 = num[0, 0]; }
if (num[0, 1] > max03 && num[0, 1] < max02){ max03 = num[0, 1]; }
if (num[0, 2] > max03 && num[0, 2] < max02){ max03 = num[0, 2]; }
if (num[0, 3] > max03 && num[0, 3] < max02){ max03 = num[0, 3]; }
num2[0, 3] = max03;

/////////////////////////////////////////// 2-я строка.

int max10 = 0;
int max11 = 0;
int max12 = 0;
int max13 = 0;

if (num[1, 0] > max10) { max10 = num[1, 0]; }
if (num[1, 1] > max10) { max10 = num[1, 1]; }
if (num[1, 2] > max10) { max10 = num[1, 2]; }
if (num[1, 3] > max10) { max10 = num[1, 3]; }
num2[1, 0] = max10; 

if (num[1, 0] > max11 && num[1, 0] < max10){ max11 = num[1, 0]; } //Console.WriteLine($"[0,1] = {max01}; "); // проверка.
if (num[1, 1] > max11 && num[1, 1] < max10){ max11 = num[1, 1]; } //Console.WriteLine($"[0,1] = {max01}; ");
if (num[1, 2] > max11 && num[1, 2] < max10){ max11 = num[1, 2]; } //Console.WriteLine($"[0,1] = {max01}; ");
if (num[1, 3] > max11 && num[1, 3] < max10){ max11 = num[1, 3]; } //Console.WriteLine($"[0,1] = {max01}; ");
num2[1, 1] = max11;

if (num[1, 0] > max12 && num[1, 0] < max11){ max12 = num[1, 0]; }
if (num[1, 1] > max12 && num[1, 1] < max11){ max12 = num[1, 1]; }
if (num[1, 2] > max12 && num[1, 2] < max11){ max12 = num[1, 2]; }
if (num[1, 3] > max12 && num[1, 3] < max11){ max12 = num[1, 3]; }
num2[1, 2] = max12;

if (num[1, 0] > max13 && num[1, 0] < max12){ max13 = num[1, 0]; }
if (num[1, 1] > max13 && num[1, 1] < max12){ max13 = num[1, 1]; }
if (num[1, 2] > max13 && num[1, 2] < max12){ max13 = num[1, 2]; }
if (num[1, 3] > max13 && num[1, 3] < max12){ max13 = num[1, 3]; }
num2[1, 3] = max13;

/////////////////////////////////////////// 3-я строка.

int max20 = 0;
int max21 = 0;
int max22 = 0;
int max23 = 0;

if (num[2, 0] > max20) { max20 = num[2, 0]; }
if (num[2, 1] > max20) { max20 = num[2, 1]; }
if (num[2, 2] > max20) { max20 = num[2, 2]; }
if (num[2, 3] > max20) { max20 = num[2, 3]; }
num2[2, 0] = max20; 

if (num[2, 0] >= max21 && num[2, 0] < max20){ max21 = num[2, 0]; } //Console.WriteLine($"[2,1] = {max21}; "); // проверка.
if (num[2, 1] >= max21 && num[2, 1] < max20){ max21 = num[2, 1]; } //Console.WriteLine($"[2,1] = {max21}; ");
if (num[2, 2] >= max21 && num[2, 2] < max20){ max21 = num[2, 2]; } //Console.WriteLine($"[2,1] = {max21}; ");
if (num[2, 3] >= max21 && num[2, 3] < max20){ max21 = num[2, 3]; } //Console.WriteLine($"[2,1] = {max21}; ");
num2[2, 1] = max21;

// тут формула изменена для правильного прохождения повтора 4-ки... 
// провбовал добавлять условия "num[i,j] == max21" используя while, if-else, if-else if 
// желаемого результата не получил. 
if (num[2, 0] >= max22 && num[2, 0] <= max21){ max22 = num[2, 0]; }//Console.WriteLine($"[2,2] = {max22}; "); 
if (num[2, 1] >= max22 && num[2, 1] <= max21){ max22 = num[2, 1]; }//Console.WriteLine($"[2,2] = {max22}; "); 
if (num[2, 2] >= max22 && num[2, 2] <= max21){ max22 = num[2, 2]; }//Console.WriteLine($"[2,2] = {max22}; "); 
if (num[2, 3] >= max22 && num[2, 3] <= max21){ max22 = num[2, 3]; }//Console.WriteLine($"[2,2] = {max22}; "); 
num2[2, 2] = max22;


if (num[2, 0] >= max23 && num[2, 0] < max22){ max23 = num[2, 0]; }//Console.WriteLine($"[2,3] = {max23}; "); 
if (num[2, 1] >= max23 && num[2, 1] < max22){ max23 = num[2, 1]; }//Console.WriteLine($"[2,3] = {max23}; "); 
if (num[2, 2] >= max23 && num[2, 2] < max22){ max23 = num[2, 2]; }//Console.WriteLine($"[2,3] = {max23}; "); 
if (num[2, 3] >= max23 && num[2, 3] < max22){ max23 = num[2, 3]; }//Console.WriteLine($"[2,3] = {max23}; "); 
num2[2, 3] = max23;

for (int i = 0; i < num.GetLength(0); i++) // демонстрация нового массива
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        Console.Write($"{num2[i, j]} ");
    }
    Console.WriteLine();
}

