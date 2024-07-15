using System;

class UserInputToCompileForTest
{
    public static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else // m > 0 && n > 0
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    public static void PrintResult(int m, int n)
    {
        int result = Ackermann(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        int m = 2;
        int n = 4;
        
        UserInputToCompileForTest.PrintResult(m, n);
    }
}
