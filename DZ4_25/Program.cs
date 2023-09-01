// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
System.Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число 2: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int power = 0; power <= num; power++)
    Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})");


