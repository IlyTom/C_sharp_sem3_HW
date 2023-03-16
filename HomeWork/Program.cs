// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInt()
{
    Console.Write("Введите число N:");
    return Convert.ToInt32(Console.ReadLine());
}

void PowCube(int n)
{
    for (int i = 1; i <= n; i++)
    {
            Console.Write($"{Math.Pow(i,3)} ");
    }
}

int N = ReadInt();
PowCube(N);
