// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк длинна которых меньше или равна 3 символа.
// массив можно задать с клавиатуры.

System.Console.WriteLine("Введите данные для массива через пробел");
String writeData = Console.ReadLine();

String[] text = writeData.Trim()
                         .Replace(".","")
                         .Replace(",", "")
                         .Split(" ");

