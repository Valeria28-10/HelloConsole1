// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
string input = Console.ReadLine();
int str_length = input.Length;
if (input.Length > 2) 
{
Console.WriteLine(input[2]);
}
else 
{
Console.WriteLine("Третьей цифры нет");
}
