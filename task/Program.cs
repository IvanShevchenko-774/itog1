
int InputNumber(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int M = InputNumber ("Введите значение М: "); 
int N = InputNumber ("Введите значение N: "); 
int sum = 0;

     for (int i = M; i <= N; i++) 
    {
        sum += i;
    }

System.Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна: {sum}");

