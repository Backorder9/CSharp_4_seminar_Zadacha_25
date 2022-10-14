/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Сделать в функции, сделать проверку на отрицательность.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


// Возведение в степень
void Power(int a, int b)
{
    int c = a;
    for (int i = 1; i < b; i++)
    {
        c = c * a;
    }
    Console.WriteLine($"Число {a} в степени {b} = {c}.");
}

Console.Write("Введите целое число-основание: ");
int numberA = int.Parse(Console.ReadLine());
if (numberA < 0) numberA = -1*numberA;

Console.Write("Введите степень, в которую надо его возвести: ");
int numberB = int.Parse(Console.ReadLine());
if (numberB < 0) numberB = -1*numberB;

Power(numberA, numberB);