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
Console.WriteLine(FindEven(array));