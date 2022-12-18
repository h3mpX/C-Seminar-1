//Семинар 1

//Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*——————————————————————————————————————————————————

Console.WriteLine("Input a first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{  
    Console.WriteLine($"Максимальное число: {num1}, а минимальное: {num2}");
}
else
{
    Console.WriteLine($"Максимальное число: {num2}, а минимальное: {num1}");
}

——————————————————————————————————————————————————*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*——————————————————————————————————————————————————

Console.WriteLine("Input a first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a third number");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max)
{  
    num2 = max;
}
else 
{
    max = num1;
}
if(num3 > max)
{
    max = num3;
    Console.WriteLine($"Максимальное число: {max}");
}
else
{
    Console.WriteLine($"Максимальное число: {max}");
}

——————————————————————————————————————————————————*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*——————————————————————————————————————————————————

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 ==0)
{
    Console.WriteLine("Число является четным");
}

else
{
    Console.WriteLine("Число не является четным");
}

*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
bool check = true;

Console.Write("Четные числа от 1 до " +num + ": ");

while(current <= num)
{
if(current % 2 == 0)
Console.Write(current + " ");
current++;
check = false;
}

if(check)
{
    Console.Write("Четных чисел нет");
}
