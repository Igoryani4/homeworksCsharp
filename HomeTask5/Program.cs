//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/* int [] ArrayThreeDigit (int size){
    
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
Console.WriteLine(FindEven(array)); */



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
int length = int.Parse(Console.ReadLine());

int[] array = ArrayRand (length);

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(FindSumOdd(array));