//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите 5-ти значное число полиндром:");
int number = int.Parse(Console.ReadLine());

if (number / 10000 == number % 10 && (number % 10000)/1000 == (number % 100)/10){
    Console.WriteLine("Число является полиндромом");
}

else
{
    Console.WriteLine("Число НЕ является полиндромом");
}


//Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Ведите координаты первой точки в формате x, + enter y, + enter z + enter :");
int[] point1 = new int[3];
for (int i = 0; i < 3 ; i++){
    point1[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Ведите координаты второй точки в формате x, + enter y, + enter z + enter :");
int[] point2 = new int[3];
for (int i = 0; i < 3 ; i++){
    point2[i] = int.Parse(Console.ReadLine());
}
int x = (point2[0] - point1[0]);
int y = (point2[1] - point1[1]);
int z = (point2[2] - point1[2]);
double distance = Math.Round(Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y,2)+Math.Pow(z,2)), 2);

System.Console.WriteLine(distance);

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53



//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введит число :");
int num = int.Parse(Console.ReadLine());

for (int i = 1 ; i <= num ; i++ ){

    if ( i == num ){
        Console.Write(Math.Pow( i , 3)+ ".");
        break;
    }
    Console.Write(Math.Pow( i , 3) + ",");
}
Console.WriteLine();