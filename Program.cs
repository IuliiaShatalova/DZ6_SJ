﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



// Console.WriteLine("Введите длину массива");
// int M = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[M];
// int amountOfPos = 0;

// void FillArray()
// {
//     for (int i = 0; i < M; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//         if (array[i]>0)
//         {
//             amountOfPos = amountOfPos + 1;
//         }
//     }
//     Console.WriteLine(String.Join(",", array));
//     Console.WriteLine($"Количество положительных чисел: {amountOfPos}");
// }

// FillArray();



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// Console.WriteLine("Введите b1");
// var b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите k1");
// var k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите b2");
// var b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите k2");
// var k2 = Convert.ToDouble(Console.ReadLine());

// var x = -(b1 - b2)/(k1-k2);
// var y = k1 * x + b1;

// Console.WriteLine($"Точка пересечения: X = {x}, Y = {y}");