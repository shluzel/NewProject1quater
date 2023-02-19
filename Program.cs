﻿void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{inArray[i]} ");
        Console.WriteLine();
    }
    
}
string [] ArrayOfThreeSymbolsOrLess (string [] inArray) {
    int count=0;
    for (int i = 0; i < inArray.GetLength(0); i++) {
        if (inArray[i].Length<=3){
            count++;
        }
    }
    string [] result = new string [count];
    int j=0;
    for (int i = 0; i < inArray.GetLength(0); i++) {
        if (inArray[i].Length<=3){
            result[j] = inArray[i];
            j++;
        }
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите элементы массива через ПРОБЕЛ, затем нажмите ENTER:");
string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("Массив, который ввел пользователь:");
PrintArray(array);
Console.WriteLine("Массив, с элементами, в которых 3 или меньше символов:");
PrintArray(ArrayOfThreeSymbolsOrLess(array));


