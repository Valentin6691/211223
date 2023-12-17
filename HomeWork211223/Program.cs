// Задача 1: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.

Console.WriteLine("Введите номер строки и столбца элемента двухмерного массива через запятую; ");
int[,] array = new int[3,3];
string input = Console.ReadLine();
var matches = System.Text.RegularExpressions.Regex.Matches(input, @"-?\d+");
int num1 = int.Parse(matches[0].Value);
int num2 = int.Parse(matches[1].Value);
void createArray()
{
for(int i = 0; i<array.GetLength(0); i++)
    {
    for(int j = 0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,50);
        }     
    }
}
void printArray()
{
for(int i = 0; i<array.GetLength(0); i++)
    {
    for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
void testing()
{
    if(num1<array.GetLength(0) && num2<array.GetLength(1))
{
    Console.WriteLine("Элемент двухмерного массива с адресом: (" + num1 + "," + num2 + ") равен:");
}
else
{
    Console.Write("Данные введены некорректно");
}
}
void searchPosition()
{
for(int i = 0; i<array.GetLength(0); i++)
    {
    for(int j = 0; j<array.GetLength(1); j++)
        {
            if(i == num1  && j == num2 )
            {
            Console.Write(array[i,j]);
            }
        }
    }
}    
Console.WriteLine();    
createArray();
printArray();
testing();
searchPosition();