// Задача 2. Напишите программу, которая на вход принимает два числа и выдает какое число большее, а какое меньшее.
/*
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2)
{ 
    Console.WriteLine($"Max number is a {num2}, min number is a {num1}");
}
else
{
Console.WriteLine($"Max number is a {num1}, min number is a {num2}");
}
*/

// Задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальные из этих чисел.
/*
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (max<num2)
{
    max = num2;
}

if (max>num3)
{
   Console.WriteLine($"Max number is a {max}");
}
else
{
    max=num3;
    Console.WriteLine($"Max number is a {max}");
}
*/

// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным.
/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%2==0)
{
Console.WriteLine($"Yes, number {num} is a even number");
}
else
{
   Console.WriteLine($"No, number {num} is not a even number"); 
}
*/

// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current <= num)
{
    if (current%2==0) Console.Write(current + ", ");
    current++;
} 
*/