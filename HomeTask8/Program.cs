/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

void creatArray(int [,] matrix){
     
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = new Random().Next(0, 10);
        
        
        }
    
    }
}

void printArray(int [,] matrix){
     System.Console.WriteLine("Исходный массив:");
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
        Console.Write($"{matrix[i,j]} ");
        
        }
    Console.WriteLine();
    }
}
void printRowOrderArray(int [,] matrix){
     System.Console.WriteLine("Упорядоченный массив");
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
        Console.Write($"{matrix[i,j]} ");
        
        }
    Console.WriteLine();
    }
}
void RowOrderArray(int[,] array){
  for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
      for (int k = 0; k < array.GetLength(1) - 1; k++){
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

System.Console.WriteLine("Это программа, которая упорядочит по убыванию элементы каждой строки двумерного массива");
System.Console.WriteLine("Введите размер массива в формате m, n и нажмите Enter");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int [,] array1 = new int [m,n];
creatArray(array1);
printArray(array1);
RowOrderArray(array1);
printRowOrderArray(array1);



/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

void FindMinRow(int[,] matrix)
{
    int[] sumRow = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumRow[i] = sum;
        sum = 0;
        /* System.Console.WriteLine(sumRow[i]); */
    }
    int minRow = sumRow[0];
    int indexRow = 0;
    for (int i = 0; i < sumRow.Length; i++)
    {
        if (sumRow[i] < minRow){
            minRow = sumRow[i];
            indexRow = i;
        }
    }
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexRow+1}");
}





System.Console.WriteLine("Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов");
System.Console.WriteLine("Введите размер массива в формате m, n и нажмите Enter");
int m1 = int.Parse(Console.ReadLine());
int n1 = int.Parse(Console.ReadLine());

int [,] array2 = new int [m1,n1];
creatArray(array2);
printArray(array2);
FindMinRow(array2);



/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


void multiplicationArray(int[,] array1, int[,] array2, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}

System.Console.WriteLine("Программа , которая будет находить произведение двух матриц");
System.Console.WriteLine("Введите размер 1-го массива в формате m, n и нажмите Enter");
int m2 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int [,] array3 = new int [m2,n2];
System.Console.WriteLine("Введите размер 2-го массива в формате m, n и нажмите Enter");
int m3 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int [,] array4 = new int [m2,n2];
int [,] resultArray = new int [m2,n3];
creatArray(array3);
creatArray(array4);
printArray(array3);
printArray(array4);
multiplicationArray(array3, array4, resultArray);
printArray(resultArray);



/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


void CreateTripleArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = new Random().Next(0,10);
            }
            
        }
        
    }
}

void printTripleArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write( $"{array[i,j,k]}{(i,j,k)} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
System.Console.WriteLine("Программа , которая будет построчно выводить массив, добавляя индексы каждого элемента");
System.Console.WriteLine("Введите размер  массива в формате x,y,z и нажмите Enter");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());
int [,,] tripleArray = new int [x,y,z];
CreateTripleArray(tripleArray);
printTripleArray(tripleArray);

/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

System.Console.WriteLine("Программа , которая заполнит спирально массив 4 на 4");
System.Console.WriteLine("Введите размер  массива в формате m , n  и нажмите Enter");
int m5 = int.Parse(Console.ReadLine());
int n5 = int.Parse(Console.ReadLine());
int [,] array5 = new int [m5,n5];
creatArray(array5);


int i=0, j, k = 0, p=1;
 
while (i < n5*m5){
    k++;
    for (j=k-1;j<m5-k+1;j++){
        array5[k-1,j]=p++;
        i++;
    }
 
    for (j=k;j<n5-k+1;j++){
        array5[j,m5-k]=p++;
        i++;
    }
 
    for (j=m5-k-1;j>=k-1;j--){
        array5[n5-k,j]=p++;
        i++;
    }
 
    for (j=n5-k-1;j>=k;j--){
        array5[j,k-1]=p++;
        i++;
    }
}
printArray(array5);