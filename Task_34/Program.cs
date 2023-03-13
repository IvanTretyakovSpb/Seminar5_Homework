/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();
int arraySize = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка ввода!");
int[] array = GetArray(arraySize);
int result = FindEvenElements(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> {result}");
//////////////////////////////////////////////////////////////////////////////////
// Запрашиваем у пользователя число для формирования массива
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}
// Возвращает массив из size элементов, заполненный случайными положительными трёхзначными числами
int[] GetArray(int size)
{
    int[] res = new int[size];
    const int minValue = 100; // вводим константы для минимиального и максимального значения диапазона трёхзначных элементов массива
    const int maxValue = 1000;
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}
// Возвращает количество четных элементов массива
int FindEvenElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if(arr[i] % 2 == 0) ++count;
    return count;
}