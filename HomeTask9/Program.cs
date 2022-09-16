/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8" */

Console.WriteLine("Это программа, которая выведет все натуральные числа в промежутке от M до N.");
Console.WriteLine("Введите первое число из интервала m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число из интервала n");
int n = int.Parse(Console.ReadLine());
int count = 0 ;
int [] numbers = new int [n+1-m];
Console.Write('"');
for (int i = m; i < n+1; i++)
{
    
    numbers[count] = i;
    if (count == numbers.Length - 1){
        Console.Write($"{numbers[count]}");
        break;
    }
    Console.Write($"{numbers[count]}, ");
    count ++;
    
}
Console.Write('"');
Console.WriteLine();

/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Это программа, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("Введите первое число из интервала m");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число из интервала n");
int b = int.Parse(Console.ReadLine());

int sum = 0;
int[] sumNumbers = new int[b + 1 - a];
int count = 0;
for (int i = a; i < b + 1; i++)
{
    sumNumbers[count]=i;
    sum += sumNumbers[count];
    count++;
}
System.Console.WriteLine($"{sum}");


/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29 */


Console.WriteLine("Это программа, которая вычисления функции Аккермана с помощью рекурсии. От M до N.");
Console.WriteLine("Введите первое число из интервала M");
int c = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число из интервала N");
int d = int.Parse(Console.ReadLine());

int findAkkerman(int a, int b){
    if (a == 0) {
        return b + 1;
    }
    if (a > 0 && b == 0) {
        return findAkkerman(a - 1, 1);
    }
    if (a > 0 && b > 0) {
        return findAkkerman(a - 1, findAkkerman(a, b - 1));
    }
    else {
        return b+1;
    }
}

Console.WriteLine($"Функция Аккермана для чисел A({c},{d}) = {findAkkerman(d,c)}");