// Задача 1: Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.

// Console.WriteLine("Введите первое число");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int N = Convert.ToInt32(Console.ReadLine());
// int firstElement = M;
// int lastElement = N;

// if(M > N)
// {
//     firstElement = N;
//     lastElement = M;
// }

// PrintNumbers(firstElement, lastElement);
// void PrintNumbers(int startEl, int endEl)
// {
//     Console.Write(startEl +" ");
//     if(startEl == endEl)
//     {
//         return;
//     }
//     PrintNumbers(startEl+1, endEl);
// }

// Задача 2: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n. 

int m = 3;
int n = 8;

int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

int result = Ackermann(m, n);
Console.WriteLine($"Ackermann({m}, {n}) = {result}");