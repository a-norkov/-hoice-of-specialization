Console.WriteLine("Введите массив строк, через запятую. пример Hello, 123!rwef, 23r23e, World!, 33");
string[] stringArray = Console.ReadLine().Split(',');
string[] parsedStringArray = new string [0];

// проходим циклом по каждому элементу массива
for (int i = 0; i < stringArray.Length; i++)
{
    // удаляем пробелы, введенные пользователем (если они есть)
    stringArray[i] = stringArray[i].Trim();

    // проверяем условие, если длина строки меньше или равна 3, то добавляем ее в новый массив.
    if (stringArray[i].Length <= 3)
    {
        // добавляем элемент в массив
        parsedStringArray =  parsedStringArray.Append (stringArray[i]).ToArray();
    }

}

Console.WriteLine("\nМассив состоящий из элементов с длиной строки меньшей либо равной 3:");
// вывод в консоль нового массива
for (int i = 0; i < parsedStringArray.Length; i++)
{
    Console.Write ($"'{parsedStringArray[i]}' ");
}