﻿// Команда для изменения кодировки в терминале
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
else if (num3 > max) max = num3;

Console.WriteLine(max);