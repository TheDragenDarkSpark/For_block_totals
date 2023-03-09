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
string GetNumber(string messege)
{
    string resulString = "Пустая строка!";
    Console.Write("Введите текст!");
    while(true)
    {
        if(int.TryParse(Console.Read(), out resulString))
        {
            break;
        }
        else
        {
            Console.Write("The string isn't entered! Enter a string: ");
        }
        return resulString;
    }
}


