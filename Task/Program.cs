// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void Main()
{
    int number = ReadInt("Введите количество элементов массива: ");
    string[] array = new string[number];
    FillArray(number, array);
    System.Console.WriteLine();
    System.Console.WriteLine("Исходный массив: ");
    PrintArray(array);
    System.Console.WriteLine();
    System.Console.WriteLine("Преобразованный массив: ");
    PrintArray(ConvertArray(array));
}

int ReadInt(string text) // метод для считывания числа из терминала
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string[] FillArray(int number, string[] array) // метод для заполнения массива пользователем
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Введите {i + 1}-й элемент массива");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

string[] ConvertArray(string[] array) // метод преобразования массива в соответсвии с условием задачи
{
    int maxLength = 3;
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength) n++;
    }
    string[] result = new string[n];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

void PrintArray(string[] array) // вывод массива в терминал
{
    System.Console.WriteLine("[" + string.Join(",  ", array) + "]");
}

Main();
