// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк длинна которых меньше или равна 3 символа.
// массив можно задать с клавиатуры.

System.Console.WriteLine("Введите данные для массива через пробел");
String writeData = Console.ReadLine();

String[] text = writeData.Trim()
                         .Replace(".","")
                         .Replace(",", "")
                         .Split(" ");

System.Console.Write("Элементы массива длинной меньше 4-х символов ");
String[] newText = selectElementsLess4Signs(text);
Console.WriteLine(String.Join(" ", newText));

static String[] selectElementsLess4Signs ( String[] argCutArray) {

int count = 0;
for (int i = 0; i < argCutArray.GetLength(0); i++)
{
  if (argCutArray[i].Length < 4) count++; 
}

String[] cutedArray = new String[count];

for (int i = 0, j = 0; i < argCutArray.Length; i++)
{
  if (argCutArray[i].Length < 4) {
    cutedArray[j] = argCutArray[i];
    j++;
  }
}
return cutedArray;
}

