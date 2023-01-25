string[] newLine = ReadData("Введите массив строк через пробел");
string[] result = FindShotElement(newLine, 3);
PrintData("Результат:", result);

// Метод получения данных от пользователя
string[] ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine()!.Split(' ').ToArray(); // Разбивает строку, разделенных пробелом
}
// Метод вывода данных
void PrintData(string msg, string[] array)
{
    Console.WriteLine(msg);
    Console.WriteLine($"[{string.Join(", ", array)}]");

}
//Метод определения длины нового массива
int CountElement(string[] array, int n)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}
//Метод поиска элементов массива меньше указанной длины
string[] FindShotElement(string[] array, int n)
{
    string[] result = new string[CountElement(array, n)];

    int size = 0;
    foreach (var value in array)
    {
        if (value.Length <= 3)
        {
            result[size] = value;
            size++;
        }
    }
    return result;
}