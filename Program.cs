/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Сделать в функции, сделать проверку на отрицательность.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


// Возведение в степень
static int Powers(int A, int B)
{
    if (A < 0) A = -A;
    if (B < 0) B = -B;
    int c = A;
    for (int i = 1; i < B; i++)
    {
        c = c * A;
    }
    // Console.WriteLine($"Число {a} в степени {b} = {c}.");
    return c;
}

void Print(int a, int b, int c)
{
    Console.WriteLine($"Число {a} в степени {b} = {c}.");
    Console.WriteLine();
}

Console.Write("Введите целое число-основание: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите степень, в которую надо его возвести: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine();

int power = Powers(numberA, numberB);
Print(numberA, numberB, power);
