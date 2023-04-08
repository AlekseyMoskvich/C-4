/*Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16



Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

if(a < 0 || b < 0){
    Console.WriteLine("Числа не должны быть ниже нуля");
    return;
}

double result = Math.Pow(a, b);
Console.WriteLine($"Первое число в степени второго = {result}");
*/

/*
Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12


Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine());

int SumNumbers = GetSumOfNumbers(Number);

Console.WriteLine($"Сумма цифр в числе равна {SumNumbers}");

int GetSumOfNumbers (int Number){

    int Sum = 0;

    while(Number > 0){
        
        Sum = Sum + Number % 10;
        Number = Number / 10;
        
    }

    return Sum;

}
*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/



