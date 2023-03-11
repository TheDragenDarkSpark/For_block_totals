/*

Задача для выполнения: 
Написать программу, которая из имющегося массива строк 
формирует массив из строк, длина которых меньше либо 
равна 3 символа. Первоначальный массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

*/

Console.Clear();

// Ввод строки:
string GetNumber()
{
    string resulString = Console.ReadLine();
    Console.WriteLine("");
    return resulString;

}


string inputText = GetNumber();

Console.WriteLine(inputText);

// Метод селекции элементов текста
void GetResult(string text)
{
    // Выделение одельных элементов;
    // Записываем их в массив;
    var data = text.Replace(",", "")
                   .Split(" ")
                   .ToArray();

    // Находим число элементов в полученном массиве
    int size = data.Length;

    string lastText = String.Empty;
    for(int i = 0; i < size; i++)
    {
        lastText = data[i];

        // Выбираем элементы массива размером до 3 символов
        if(data[i].Length <= 3)
        {
            var value = data[i];
            Console.Write($"{value}, ");
        }
    }

}

Console.WriteLine("");

// Вызываем метод:
GetResult(inputText);