﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Number = 2;

if(N > 1)
{
    while(Number <= N)
    {
        Console.Write(Number + " ");
        Number = Number + 2;
    }
}

