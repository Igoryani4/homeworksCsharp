 /* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
 Ввод чисел происходит через Enter, останавливается при введении слова "stop"

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

int num = 100;
int[] array = new int[num];
int count = 0;
for (int i = 0; i < num ; i++){
    Console.WriteLine("Введите число и нажмите Enter, если хотите прервать ввод наберите stop");
    var x1 = Console.ReadLine();
    if (x1 == "stop"){
        break;
    }
    else {
        array[i] = int.Parse(x1);
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++; 
}
Console.WriteLine($"Количество введенных чисел больше нуля равно {count}");


 /* Напишите программу, которая найдёт точку пересечения двух прямых,
  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


int num2 = 4;
double[] arr = new double[num2];
for (int i = 0; i < num2 ; i++){
    System.Console.WriteLine("Введите координаты прямых в формате b1, k1, b2 и k2 и нажмите Enter после каждого значения");
    arr[i] = int.Parse(Console.ReadLine());

}
if (arr[1]==arr[3]) Console.WriteLine("Заданные прямые параллельны, введите другие значения");
else{
    double x = (arr[2]-arr[0])/(arr[1]-arr[3]);
    double y = arr[1]*((arr[2]-arr[0])/(arr[1]-arr[3]))+arr[0];
    System.Console.WriteLine($"Координаты точки пересечения заданных прямых {x},{y}");
}

 
 /* x=(b2-b1)/(k1-k2) , y=k1(b2-b1)10/(k1-k2)+b1 */