// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second numbe: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.Write("Первое число " + num1 + " больше чем второе " + num2);
}
else
{
    Console.Write("Второе число " + num2 + " больше чем первое " + num1);
}
*/

// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max)
{
    max = num2;
}
if(num3 > max)
{
    max = num3;
}
Console.Write("Наибольшее из введёных чисел " + max);
*/

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 1)
{
    Console.Write("Число " + num + " является нечётным!");
}
else
{
    Console.Write("Число " + num + " является чётным!");
}
*/

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 1;

Console.WriteLine("Чётные числа от 1 до " + n);

while(current <= n)
{
    if(current % 2 != 1)
    {
        Console.Write(current + " ");
        
    }
    current++;
}
*/
