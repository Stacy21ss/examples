﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100, 1000);
int digit1 = number / 100;
int digit3 = number % 10;
int result = digit1 * 10 + digit3; 
System.Console.WriteLine($"Ваше случайное число: {number}");
Console.WriteLine(result);

