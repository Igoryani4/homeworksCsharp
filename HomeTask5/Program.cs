//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int [] ArrayThreeDigit (int size){
    
    int[] array = new int [size];
    for (int i = 0; i < array.Length; i ++){
        array[i] = new Random().Next(100 , 999);
    }
    return array;
}

int FindEven (int[] array){
    int count = 0;
    for( int i= 0 ; i < array.Length ; i ++){
        if (array[i] % 2 == 0){
            count ++;
        }

    }
    return count;
} 


Console.WriteLine("Введите значение длины массива");
int length = int.Parse(Console.ReadLine());

int[] array = ArrayThreeDigit(length);

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("количество чётных чисел в массиве:");
Console.WriteLine(FindEven(array));



// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int [] ArrayRand (int size){
    
    int[] array = new int [size];
    for (int i = 0; i < array.Length; i ++){
        array[i] = new Random().Next(1 , 999);
    }
    return array;
}

int FindSumOdd (int[] array){
    int Sum = 0;
    for( int i= 0 ; i < array.Length ; i ++){
        if (i % 2 == 1){
            Sum += array[i];
        }

    }
    return Sum;
} 


Console.WriteLine("Введите значение длины массива");
int length1 = int.Parse(Console.ReadLine());

int[] array1 = ArrayRand (length1);

Console.WriteLine($"[{string.Join(", ", array1)}]");
Console.WriteLine("сумма элементов, стоящих на нечётных позициях:");
Console.WriteLine(FindSumOdd(array1));


// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int [] ArrayNumber (int size){
    
    int[] array = new int [size];
    for (int i = 0; i < array.Length; i ++){
        array[i] = new Random().Next(-999 , 999);
    }
    return array;
}

int FindDiff (int[] array)
{
    int Min = 10^9;
    int Max = -10^9;
    
    for( int i= 0; i < array.Length; i ++){
        if (array[i] < Min){
            Min = array[i];
        }
        if (array[i] > Max){
            Max = array[i];
        }
    }
    int Difference = Max - Min;
    return Difference;
} 


Console.WriteLine("Введите значение длины массива");
int length2 = int.Parse(Console.ReadLine());

int[] array2 = ArrayNumber (length2);

Console.WriteLine($"[{string.Join(", ", array2)}]");
Console.WriteLine("разница между максимальным и минимальным элементов массива:");
Console.WriteLine(FindDiff(array2));