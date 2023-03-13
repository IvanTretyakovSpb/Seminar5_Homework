// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
int arraySize = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка ввода!");
double[] array = GetArray(arraySize);
double result = FindDeltaMaxMinElements(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> {result:f}");
//////////////////////////////////////////////////////////////////////////////////
// Запрашивает у пользователя целые числа для параметов массива
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
// Возвращает массив вещественных чисел из size элементов
double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * 100;
    }
    return res;
}
// Возвращает максимальное значение элемента массива arr
double FindMaxElement(double[] arr)
{
    double maxEl = arr[0];
    for (int i = 1; i < arr.Length; i++)
        if(arr[i] > maxEl) maxEl = arr[i];
    return maxEl;
}
// Возвращает минимальное значение элемента массива arr
double FindMinElement(double[] arr)
{
    double minEl = arr[0];
    for (int i = 1; i < arr.Length; i++)
        if(arr[i] < minEl) minEl = arr[i];
    return minEl;
}
double FindDeltaMaxMinElements(double[] arr)
{
    double delta = FindMaxElement(arr) - FindMinElement(arr);
    return delta;
}