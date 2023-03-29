class Program 
{
    static int Ackermann(int m, int n) {
        if (m == 0) 
        {
            return n + 1;
        }
        else if (n == 0) 
        {
            return Ackermann(m - 1, 1);
        }
        else 
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main() 
    {
        Console.Write("Введите количество пар чисел: ");
        int count = int.Parse(Console.ReadLine());

       int[,] pairs = new int[count, 2];

        Console.WriteLine("Введите пары чисел через пробел:");

        for (int i = 0; i < count; i++) 
        {
            Console.Write($"Пара {i + 1} (m n): ");
            string[] input = Console.ReadLine().Split(' ');
            pairs[i, 0] = int.Parse(input[0]);
            pairs[i, 1] = int.Parse(input[1]);
        }

        Console.WriteLine("Результаты:");

        for (int i = 0; i < count; i++) 
        {
            int m = pairs[i, 0];
            int n = pairs[i, 1];
            int result = Ackermann(m, n);
            Console.WriteLine($"A({m}, {n}) = {result}");
        }
    }
}
