// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
int arraySize = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка ввода!");
int arrayMin = GetNumberFromUser("Введите минимальное значение элемента массива: ", "Ошибка ввода!");
int arrayMax = GetNumberFromUser("Введите максимальное значение элемента массива: ", "Ошибка ввода!");
int[] array = GetArray(arraySize, arrayMin, arrayMax);
int result = FindSumOddElements(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> {result}");
//////////////////////////////////////////////////////////////////////////////////
// Запрашивает у пользователя целые числа для параметов массива
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}
// Возвращает массив из size элементов,
// заполненный случайными числами из промежутка [minValue, maxValue]
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
// Возвращает сумму элементов массива arr, стоящих на нечётных позициях 
int FindSumOddElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if(i % 2 != 0) sum += arr[i];
    return sum;
}