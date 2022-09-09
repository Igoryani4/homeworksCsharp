/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */
void creatRandomMatrix(double [,] matrix){
     
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
        matrix[i,j] = new Random().Next(-10/1,10/1);
        matrix[i,j] = matrix[i,j];
        Console.Write($"{matrix[i,j]} ");
        }
    Console.WriteLine();
    }
}
Console.WriteLine("Введите количсво столбцов и строк через Enter:");
int rows = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
double [,] matrix = new double [rows,column];
creatRandomMatrix(matrix );



/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
/ и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4 */

void creatRandomMatrix1(double [,] matrix){
     
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
        matrix[i,j] = new Random().Next(-10,10);
        matrix[i,j] = matrix[i,j];
        
        }
    
    }
}

void printRandomMatrix1(double [,] matrix){
     
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
        Console.Write($"{matrix[i,j]} ");
        
        }
    Console.WriteLine();
    }
}

int rows1 = 4;
int column1 = 4;
double [,] matrix1= new double [rows1,column1];
creatRandomMatrix1(matrix1 );

System.Console.WriteLine("Ведите индексы в формате строки, столбцы и нажмите Enter.");
int findRows = int.Parse(Console.ReadLine());
int findColums = int.Parse(Console.ReadLine());

if (findRows <= rows1 && findColums <= column1){
    
    Console.WriteLine($"Значение элемента по заданным значениям равно = {matrix1[findRows, findColums]}");
}

else{
    Console.WriteLine("такого элемента нет, попробуйте снова))");
    
}
printRandomMatrix1(matrix1);




/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


void creatRandomMatrix2(double [,] matrix){
     
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
        matrix[i,j] = new Random().Next(1,10);
        matrix[i,j] = matrix[i,j];
        
        }
    
    }
}

void printRandomMatrix2(double [,] matrix){
     
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
        Console.Write($"{matrix[i,j]} ");
        
        }
    Console.WriteLine();
    }
}

int rows2 = 4;
int column2 = 4;
double [,] matrix2= new double [rows2,column2];
creatRandomMatrix2(matrix2 );
printRandomMatrix2(matrix2);
double [] result = new double[column2];
for (int i = 0; i < matrix2.GetLength(0); i++){
    for (int j = 0; j < matrix2.GetLength(1); j++){
        result[j] += matrix2[i,j];
        
    }
}
for (int i = 0; i < result.Length; i++)
{
    result[i] /= column2;
}
Console.WriteLine($"[{string.Join(", ", result)}]");