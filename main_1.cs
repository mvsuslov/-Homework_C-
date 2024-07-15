using System;

class UserInputToCompileForTest
{
    public static void PrintNumbers(int M, int N)
    {
        if (M > N)
        {
            // Условие выхода из рекурсии
            return;
        }
        
        Console.WriteLine(M); // Вывод текущего числа
        
        // Рекурсивный вызов для следующего числа
        PrintNumbers(M + 1, N);
    }

    public static void PrintResult(int M, int N)
    {
        Console.WriteLine($"Натуральные числа от {M} до {N}:");
        PrintNumbers(M, N);
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        int M, N;

        if (args.Length >= 2 && int.TryParse(args[0], out M) && int.TryParse(args[1], out N))
        {
            UserInputToCompileForTest.PrintResult(M, N);
        }
        else
        {
            // Если аргументов на входе нет или они некорректны, используем примерные значения
            M = 1;
            N = 10;
            UserInputToCompileForTest.PrintResult(M, N);
        }
    }
}