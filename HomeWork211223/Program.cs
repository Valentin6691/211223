// Задача 1: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Console.WriteLine("Введите номер строки и столбца элемента двухмерного массива через запятую; ");
// int[,] array = new int[3,3];
// string input = Console.ReadLine();
// var matches = System.Text.RegularExpressions.Regex.Matches(input, @"-?\d+");
// int num1 = int.Parse(matches[0].Value);
// int num2 = int.Parse(matches[1].Value);
// void createArray()
// {
// for(int i = 0; i<array.GetLength(0); i++)
//     {
//     for(int j = 0; j<array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,50);
//         }     
//     }
// }
// void printArray()
// {
// for(int i = 0; i<array.GetLength(0); i++)
//     {
//     for(int j = 0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// void testing()
// {
//     if(num1<array.GetLength(0) && num2<array.GetLength(1))
// {
//     Console.WriteLine("Элемент двухмерного массива с адресом: (" + num1 + "," + num2 + ") равен:");
// }
// else
// {
//     Console.Write("Такого элемента не существует");
// }
// }
// void searchPosition()
// {
// for(int i = 0; i<array.GetLength(0); i++)
//     {
//     for(int j = 0; j<array.GetLength(1); j++)
//         {
//             if(i == num1  && j == num2 )
//             {
//             Console.Write(array[i,j]);
//             }
//         }
//     }
// }    
// Console.WriteLine();    
// createArray();
// printArray();
// testing();
// searchPosition();

// Задача 2: Задайте двумерный массив. Напишите 
// программу, которая поменяет местами первую и 
// последнюю строку массива.

// int[,] array = new int[5,5];
// int[,] array2 = new int[5,5];
// void createArray()
// {
// for(int i = 0; i<array.GetLength(0); i++)
//     {
//     for(int j = 0; j<array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }     
//     }
// }
// void printArray()
// {
// for(int i = 0; i<array.GetLength(0); i++)
//     {
//     for(int j = 0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void createArray2()
// {
// for(int i = 0; i<array2.GetLength(0); i++)
//     {
//     for(int j = 0; j<array2.GetLength(1); j++)
//         {
//            if(i>0  && i<array2.GetLength(0)-1)
//            {
//            array2[i,j] = array[i,j];
//            }
//            else
//            {
//             array2[i,j] = array[array.GetLength(0) - i - 1,j];
//            }
//         }     
//     }
// }
// void printArray2()
// {
// for(int i = 0; i<array2.GetLength(0); i++)
//     {
//     for(int j = 0; j<array2.GetLength(1); j++)
//         {
//             Console.Write(array2[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// createArray();
// printArray();
// createArray2();
// printArray2();

// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

// int[,] array = new int[3,3];
// void createArray()
// {
// for(int i = 0; i<array.GetLength(0); i++)
//     {
//     for(int j = 0; j<array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }     
//     }
// }
// void printArray()
// {
// for(int i = 0; i<array.GetLength(0); i++)
//     {
//     for(int j = 0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void minSumRowArray()
// {
//     int minSum = int.MaxValue;
//     int minSumRowIndex = -1;
//     for(int i = 0; i<array.GetLength(0); i++)
//     {
//         int rowSum = 0;
//     for(int j = 0; j<array.GetLength(1); j++)
//         {
//             rowSum = rowSum + array[i,j];
//         } 
//             if(rowSum < minSum)
//                 {
//                     minSum = rowSum;
//                     minSumRowIndex = i;
//                 }  
//     }
//         Console.WriteLine(minSum); 
//         Console.WriteLine($"Строка с индексом {minSumRowIndex} с суммой: {minSum}");
// }
// createArray();
// printArray();
// minSumRowArray();

// Задача 4*(не обязательная): Задайте двумерный массив 
// из целых чисел. Напишите программу, которая удалит 
// строку и столбец, на пересечении которых расположен 
// наименьший элемент массива. Под удалением 
// понимается создание нового двумерного массива без 
// строки и столбца

// int[,] array = new int[3,3];
// void createArray()
// {
// for(int i = 0; i<array.GetLength(0); i++)
//     {
//     for(int j = 0; j<array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }     
//     }
// }
// void printArray()
// {
// for(int i = 0; i<array.GetLength(0); i++)
//     {
//     for(int j = 0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void indexMinElem()
// {
//     int minElem = int.MaxValue;
//     int minElemIndexRow = -1;
//     int minElemIndexCol = -1;
//     for(int i = 0; i<array.GetLength(0); i++)
//     {
//     for(int j = 0; j<array.GetLength(1); j++)
//         {
//             if(array[i,j] < minElem)
//                 {
//                     minElem = array[i,j];
//                     minElemIndexRow = i;
//                     minElemIndexCol = j;
//                 }  
//         } 
//     }
//         Console.WriteLine(minElem); 
//         Console.WriteLine("Индекс минимального элемента " + minElemIndexRow +", " + minElemIndexCol);
// for(int i = 0; i<array.GetLength(0); i++)
//     {
//         if(i == minElemIndexRow)
//         {
//             continue;  
//         }
//     for(int j = 0; j<array.GetLength(1); j++)
//         {
//             if(j == minElemIndexCol)
//                 {
//                  continue;   
//                 }  
//                 Console.Write(array[i,j] + " ");
//         } 
//         Console.WriteLine();
//     }  
// }
// createArray();
// printArray();
// indexMinElem();

int[,] array = new int[4,5];
void createArray()
{
for(int i = 0; i<array.GetLength(0); i++)
    {
    for(int j = 0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }     
    }
}
void printArray()
{
Console.WriteLine("Изначальный массив");
for(int i = 0; i<array.GetLength(0); i++)
    {
    for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
void indexMinElem()
{
    int minElem = int.MaxValue;
    int minElemIndexRow = -1;
    int minElemIndexCol = -1;
    for(int i = 0; i<array.GetLength(0); i++)
    {
    for(int j = 0; j<array.GetLength(1); j++)
        {
            if(array[i,j] < minElem)
                {
                    minElem = array[i,j];
                    minElemIndexRow = i;
                    minElemIndexCol = j;
                }  
        } 
    }
        Console.WriteLine("Минимальный элемент массива равен: " + minElem); 
        Console.WriteLine("Индекс минимального элемента " + minElemIndexRow +", " + minElemIndexCol);
Console.WriteLine("Новый массив");
int[,] array1 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
for(int i = 0; i<array.GetLength(0);i++)
    {
        if(i == minElemIndexRow)
        {
            i = i + 1;  
        }
    for(int k = 0; k<array1.GetLength(0);k++)
        {
             for(int j = 0; j<array.GetLength(0);j++)
             {
                if(j == minElemIndexCol)
                {
                    j = j + 1;
                }
                for(int n = 0; n<array1.GetLength(0);n++)
                {
                    array1[k,n] = array[i,j];
                    Console.Write(array1[k,n] + " ");
                    j = j + 1;
                }
             }
             i = i + 1;
              Console.WriteLine();
        }
    }  
}
createArray();
printArray();
indexMinElem();