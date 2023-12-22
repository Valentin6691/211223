// Задача 1: Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.

Console.WriteLine("Введите первое число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int N = Convert.ToInt32(Console.ReadLine());
int firstElement = M;
int lastElement = N;

if(M > N)
{
    firstElement = N;
    lastElement = M;
}

PrintNumbers(firstElement, lastElement);
void PrintNumbers(int startEl, int endEl)
{
    Console.Write(startEl +" ");
    if(startEl == endEl)
    {
        return;
    }
    PrintNumbers(startEl+1, endEl);
}