﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 100)
{
    int result = number % 10;
    Console.WriteLine(result);
}

else Console.WriteLine ("Третьей цифры нет, попробуйте ввести другое число ");