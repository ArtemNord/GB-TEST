﻿// Задача: "Написать программу, которая из имеющегося массива строк формирует массив из строк,
//          длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с
//          клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//          лучше обойтись исключительно массивами."
// Примеры: 
//         1) ["hello","2","world",":-)] -> ["2",":-)"]
//         2) ["1234","1567","-2","computer science"] -> ["-2"]
//         3) ["Russia","Denmark","Kazan"] -> []

string [] GetStringArray (int N)
{
    string [] TempArray = new string [N];
    for(int i = 0; i != N; i++)
    {
        Console.Write($"Введите елемент {i + 1}: ");
        TempArray[i] = Console.ReadLine();
    }
    return TempArray;
}

string [] SortArray(string [] StringArray1)
{
    string [] TempStringArray = new string [StringArray1.Length];

    for (int i = 0; i < StringArray1.Length; i++)
    {   
        if (StringArray1[i].Length <= 3)
        {
            TempStringArray[i] = StringArray1[i];
        }
    }
    return TempStringArray;
}

void ShowArray(string [] array)
{
    Console.Write($"Элементы массива c 3-мя или меньше символов:");
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write($" {array[i]}");
    }
}

Console.WriteLine("Какое количество элементов вы хотите ввести?");
int ElementNumbers = Convert.ToInt32(Console.ReadLine());

string [] FirstString = GetStringArray(ElementNumbers);
string [] ResultString = SortArray(FirstString);
ShowArray(ResultString);