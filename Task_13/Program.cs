// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int num = new Random().Next(1, 100000);

Console.WriteLine("Число = " + num);
string text = num.ToString();

if (num < 100) Console.WriteLine($"третьей цифры нет");
else Console.WriteLine("Третье число: " + num + "-> " + text[2]);