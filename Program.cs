﻿Console.Clear();
string[] ArrayStrings = new string[] { };
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
ArrayStrings = new string[n];
for (int i = 0; i < ArrayStrings.Length; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    ArrayStrings[i] = Console.ReadLine();
}
Console.WriteLine();
Console.Write("Массив введенных данных:");
Console.Write($"{PrintArray(ArrayStrings)}");
Console.WriteLine();

int length = 3;  // задаем парметр длины элемент массива, который согласно заданию озвучен

// функция определения количества элемента массива длина которых меньше какой-то заданной длины length
int CheckArray(string[] array, int length)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length) result++;
    }
    return result;
}

int numbers = CheckArray(ArrayStrings, length); 
// вводим новую переменную в которую будем присваивать вычесленный элемент массива меньше либо равна 3 символа 

string[] newArrayStrings = new string[numbers]; // создаем новый массив
NewArray(ArrayStrings, newArrayStrings, length);

// функция формирования нового массива строк
void NewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimit)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}

// функция вывода массива
string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += ", ";
    }
    result += " ]";
    return result;
}

Console.Write("Элементы массива длина которых меньше либо равна 3 символа:");
Console.Write($"{PrintArray(newArrayStrings)}");
