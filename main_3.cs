using System;

class UserInputToCompileForTest
{
    public static void PrintArrayReverse(int[] arr, int index)
    {
        // Базовый случай: когда индекс становится меньше нуля, рекурсия завершается
        if (index < 0)
        {
            return;
        }

        // Шаг рекурсии: выводим текущий элемент и вызываем рекурсивно функцию для следующего элемента
        Console.Write(arr[index] + " ");
        PrintArrayReverse(arr, index - 1);
    }

    public static void PrintResult(int[] array)
    {
        // Начинаем вывод с последнего элемента, поэтому передаем в функцию длину массива - 1
        PrintArrayReverse(array, array.Length - 1);
        Console.WriteLine(); // Для перехода на новую строку после вывода массива
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        // Пример произвольного массива
        int[] array = { 1, 2, 3, 4, 5 };

        UserInputToCompileForTest.PrintResult(array);
    }
}
