# **Задача:**
"Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами."
## Примеры: 
        1) ["hello","2","world",":-)] -> ["2",":-)"]
        2) ["1234","1567","-2","computer science"] -> ["-2"]
        3) ["Russia","Denmark","Kazan"] -> []

# **Ход решения поставленной задачи:**

* [Написал блок-схему алгоритма для выполнения задания.](https://drive.google.com/file/d/18797HwE_nC2eumypRVyjZfOCODtzYVny/view?usp=sharing)
* Так же приложил блок-схему в виде файла к репозиторию.

* Решил что ввод данных для массива будет происходить через консоль. В связи с этим создал метод **GetStringArray** для заполнения массива.
* Для решения дальнейшей задачи был создан метод **SortArray**, в котором происходит создание 2го массива, для внесения в него всех элементов равных или меньше 3-х символов.
### *__Фрагмент кода__*  

``` 
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
```
* Для вывода инвормации в консоль создал метод **ShowArray**.
* Замерджил все ветки в main, проверил код на работоспособность.
* Результат положительный.